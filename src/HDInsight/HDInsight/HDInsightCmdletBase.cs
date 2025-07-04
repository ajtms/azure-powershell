﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Hyak.Common;
using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Common.MSGraph.Version1_0;
using Microsoft.Azure.Commands.HDInsight.Models;
using Microsoft.Azure.Commands.ResourceManager.Common;
using Microsoft.Azure.Management.HDInsight.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Azure.Commands.HDInsight.Commands
{
    public class HDInsightCmdletBase : AzureRMCmdlet
    {
        private AzureHdInsightManagementClient _hdInsightManagementClient;
        private AzureHdInsightJobManagementClient _hdInsightJobClient;
        private IMicrosoftGraphClient _graphClient;
        protected BasicAuthenticationCloudCredentials _credential;
        protected string _clusterName;

        public AzureHdInsightManagementClient HDInsightManagementClient
        {
            get
            {
                return _hdInsightManagementClient ??
                       (_hdInsightManagementClient = new AzureHdInsightManagementClient(DefaultContext));
            }
            set { _hdInsightManagementClient = value; }
        }

        public AzureHdInsightJobManagementClient HDInsightJobClient
        {
            get
            {
                if (_hdInsightJobClient == null || !_hdInsightJobClient.ClusterName.Equals(_clusterName))
                {
                    return new AzureHdInsightJobManagementClient(_clusterName, _credential);
                }
                return _hdInsightJobClient;
            }
            set { _hdInsightJobClient = value; }
        }

        public IMicrosoftGraphClient GraphClient
        {
            get
            {
                if (_graphClient != null) return _graphClient;
                try
                {
                    _graphClient = AzureSession.Instance.ClientFactory.CreateArmClient<MicrosoftGraphClient>(DefaultContext, AzureEnvironment.ExtendedEndpoint.MicrosoftGraphUrl);
                    (_graphClient as MicrosoftGraphClient).TenantID = DefaultContext.Tenant.Id.ToString();
                }
                catch
                {
                    _graphClient = null;
                }
                return _graphClient;
            }
            set { _graphClient = value; }
        }

        protected string GetClusterConnection(string resourceGroupName, string clusterName)
        {
            if (clusterName.Contains("."))
            {
                return clusterName;
            }
            var cluster = HDInsightManagementClient.GetCluster(resourceGroupName, clusterName);
            if (cluster.First() == null)
            {
                throw new NullReferenceException(string.Format("Could not find cluster {0} in resource group {1}",
                    clusterName, resourceGroupName));
            }
            var azurecluster = new AzureHDInsightCluster(cluster.First());
            var state = azurecluster.ClusterState;
            if (
                !(state.Equals("Running", StringComparison.OrdinalIgnoreCase) ||
                  state.Equals("Operational", StringComparison.OrdinalIgnoreCase)))
            {
                throw new NotSupportedException(
                    string.Format("The cluster {0} is in the {1} state and canot be used at this time.", clusterName,
                        state));
            }

            var httpEndpoint = azurecluster.HttpEndpoint;
            if (httpEndpoint == null)
            {
                throw new NotSupportedException(
                    string.Format(
                        "Cannot use cluster {0} because HTTP is not enabled on it. Please use the {1} cmdlet to HTTP and try again.",
                        azurecluster.Name, "Grant-" + Constants.CommandNames.AzureHDInsightHttpServicesAccess));
            }
            return httpEndpoint;
        }

        protected string GetResourceGroupByAccountName(string clusterName)
        {
            try
            {
                var clusterId = HDInsightManagementClient.ListClusters().First(x => x.Name.Equals(clusterName, StringComparison.InvariantCultureIgnoreCase)).Id;
                var rgStart = clusterId.IndexOf("resourceGroups/", StringComparison.InvariantCultureIgnoreCase) + ("resourceGroups/".Length);
                var rgLength = (clusterId.IndexOf("/providers/", StringComparison.InvariantCultureIgnoreCase)) - rgStart;
                return clusterId.Substring(rgStart, rgLength);
            }
            catch
            {
                throw new CloudException(string.Format("Could not find resource group for cluster {0}.", clusterName));
            }
        }

        protected AzureHDInsightDefaultStorageAccount GetDefaultStorageAccount(string resourceGroupName, string clusterName)
        {
            var result = HDInsightManagementClient.GetCluster(resourceGroupName, clusterName);

            if (result == null || result.Count == 0)
            {
                throw new CloudException(string.Format("Couldn't find cluster {0}", clusterName));
            }

            var cluster = result.FirstOrDefault();
            var coreSiteConfiguration = HDInsightManagementClient.GetClusterConfigurations(resourceGroupName, cluster.Name, ConfigurationKey.CoreSite);
            var clusterIdentityConfiguration = HDInsightManagementClient.GetClusterConfigurations(resourceGroupName, cluster.Name, ConfigurationKey.ClusterIdentity);

            var DefaultStorageAccount = ClusterConfigurationUtils.GetDefaultStorageAccountDetails(
                                                cluster.Properties.ClusterVersion,
                                                coreSiteConfiguration,
                                                clusterIdentityConfiguration
                                         );

            if (DefaultStorageAccount == null)
            {
                throw new CloudException(string.Format("Couldn't find storage information for cluster {0}", clusterName));
            }

            return DefaultStorageAccount;
        }

        protected Dictionary<string, Dictionary<string, string>> GetDefaultVmsizesConfigurations(string location)
        {
            Dictionary<string, Dictionary<string, string>> nodeTypeAndClusterTypeAndVmSizeDict = null;
            try
            {
                BillingResponseListResult billingResponseListResult = HDInsightManagementClient.ListBillingSpecs(location);

                /* The result is KeyValuePair<ZOOKEEPERNODEROLE, KeyValulePair<SPARK, STANDARD_A2_V2>> */
                var nodeTypeAndClusterTypeAndVmSizePairs = billingResponseListResult.VMSizeFilters.Where(filter => filter.FilterMode.Equals(FilterMode.Default)).SelectMany(x =>
                {
                    var clusterTypeAndVmSizePairs = x.ClusterFlavors.SelectMany(clusterType => x.VMSizes, (clusterType, vmSize) =>
                    {
                        return new KeyValuePair<string, string>(clusterType.ToUpper(), vmSize);
                    });

                    var result = x.NodeTypes.SelectMany(nodeType => clusterTypeAndVmSizePairs, (nodeType, clusterTypeAndVmSizePair) => { return new KeyValuePair<string, KeyValuePair<string, string>>(nodeType.ToUpper(), clusterTypeAndVmSizePair); });
                    return result;
                });

                nodeTypeAndClusterTypeAndVmSizeDict = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);
                foreach (var pair in nodeTypeAndClusterTypeAndVmSizePairs)
                {
                    if (!nodeTypeAndClusterTypeAndVmSizeDict.TryGetValue(pair.Key, out var tempDict))
                    {
                        nodeTypeAndClusterTypeAndVmSizeDict[pair.Key] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                        nodeTypeAndClusterTypeAndVmSizeDict[pair.Key].Add(pair.Value.Key, pair.Value.Value);
                    }
                    else
                    {
                        nodeTypeAndClusterTypeAndVmSizeDict[pair.Key].Add(pair.Value.Key, pair.Value.Value);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return nodeTypeAndClusterTypeAndVmSizeDict;
        }
    }
}
