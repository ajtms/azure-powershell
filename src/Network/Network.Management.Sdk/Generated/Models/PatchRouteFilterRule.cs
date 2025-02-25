// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Route Filter Rule Resource.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class PatchRouteFilterRule : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the PatchRouteFilterRule class.
        /// </summary>
        public PatchRouteFilterRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatchRouteFilterRule class.
        /// </summary>

        /// <param name="id">Resource ID.
        /// </param>

        /// <param name="name">The name of the resource that is unique within a resource group. This name
        /// can be used to access the resource.
        /// </param>

        /// <param name="etag">A unique read-only string that changes whenever the resource is updated.
        /// </param>

        /// <param name="access">The access type of the rule.
        /// Possible values include: &#39;Allow&#39;, &#39;Deny&#39;</param>

        /// <param name="provisioningState">The provisioning state of the route filter rule resource.
        /// Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;,
        /// &#39;Updating&#39;, &#39;Deleting&#39;</param>

        /// <param name="routeFilterRuleType">The rule type of the rule.
        /// Possible values include: &#39;Community&#39;</param>

        /// <param name="communities">The collection for bgp community values to filter on. e.g.
        /// [&#39;12076:5010&#39;,&#39;12076:5020&#39;].
        /// </param>
        public PatchRouteFilterRule(string id = default(string), string name = default(string), string etag = default(string), string access = default(string), string provisioningState = default(string), string routeFilterRuleType = default(string), System.Collections.Generic.IList<string> communities = default(System.Collections.Generic.IList<string>))

        : base(id)
        {
            this.Name = name;
            this.Etag = etag;
            this.Access = access;
            this.ProvisioningState = provisioningState;
            this.RouteFilterRuleType = routeFilterRuleType;
            this.Communities = communities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the name of the resource that is unique within a resource group. This
        /// name can be used to access the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is
        /// updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag {get; private set; }

        /// <summary>
        /// Gets or sets the access type of the rule. Possible values include: &#39;Allow&#39;, &#39;Deny&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.access")]
        public string Access {get; set; }

        /// <summary>
        /// Gets the provisioning state of the route filter rule resource. Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;, &#39;Updating&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets the rule type of the rule. Possible values include: &#39;Community&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.routeFilterRuleType")]
        public string RouteFilterRuleType {get; set; }

        /// <summary>
        /// Gets or sets the collection for bgp community values to filter on. e.g.
        /// [&#39;12076:5010&#39;,&#39;12076:5020&#39;].
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.communities")]
        public System.Collections.Generic.IList<string> Communities {get; set; }
    }
}