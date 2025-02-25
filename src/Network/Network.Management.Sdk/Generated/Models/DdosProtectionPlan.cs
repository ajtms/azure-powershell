// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// A DDoS protection plan in a resource group.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class DdosProtectionPlan : Microsoft.Rest.Azure.IResource
    {
        /// <summary>
        /// Initializes a new instance of the DdosProtectionPlan class.
        /// </summary>
        public DdosProtectionPlan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DdosProtectionPlan class.
        /// </summary>

        /// <param name="id">Resource ID.
        /// </param>

        /// <param name="name">Resource name.
        /// </param>

        /// <param name="type">Resource type.
        /// </param>

        /// <param name="location">Resource location.
        /// </param>

        /// <param name="tags">Resource tags.
        /// </param>

        /// <param name="etag">A unique read-only string that changes whenever the resource is updated.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the DDoS protection plan resource.
        /// Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;,
        /// &#39;Updating&#39;, &#39;Deleting&#39;</param>

        /// <param name="resourceGuid">The resource GUID property of the DDoS protection plan resource. It
        /// uniquely identifies the resource, even if the user changes its name or
        /// migrate the resource across subscriptions or resource groups.
        /// </param>

        /// <param name="publicIPAddresses">The list of public IPs associated with the DDoS protection plan resource.
        /// This list is read-only.
        /// </param>

        /// <param name="virtualNetworks">The list of virtual networks associated with the DDoS protection plan
        /// resource. This list is read-only.
        /// </param>
        public DdosProtectionPlan(string id = default(string), string name = default(string), string type = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string etag = default(string), string provisioningState = default(string), string resourceGuid = default(string), System.Collections.Generic.IList<SubResource> publicIPAddresses = default(System.Collections.Generic.IList<SubResource>), System.Collections.Generic.IList<SubResource> virtualNetworks = default(System.Collections.Generic.IList<SubResource>))

        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Location = location;
            this.Tags = tags;
            this.Etag = etag;
            this.ProvisioningState = provisioningState;
            this.ResourceGuid = resourceGuid;
            this.PublicIPAddresses = publicIPAddresses;
            this.VirtualNetworks = virtualNetworks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets resource ID.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; private set; }

        /// <summary>
        /// Gets resource name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; private set; }

        /// <summary>
        /// Gets resource type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; private set; }

        /// <summary>
        /// Gets or sets resource location.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location {get; set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags {get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is
        /// updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag {get; private set; }

        /// <summary>
        /// Gets the provisioning state of the DDoS protection plan resource. Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;, &#39;Updating&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets the resource GUID property of the DDoS protection plan resource. It
        /// uniquely identifies the resource, even if the user changes its name or
        /// migrate the resource across subscriptions or resource groups.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid {get; private set; }

        /// <summary>
        /// Gets the list of public IPs associated with the DDoS protection plan
        /// resource. This list is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.publicIPAddresses")]
        public System.Collections.Generic.IList<SubResource> PublicIPAddresses {get; private set; }

        /// <summary>
        /// Gets the list of virtual networks associated with the DDoS protection plan
        /// resource. This list is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.virtualNetworks")]
        public System.Collections.Generic.IList<SubResource> VirtualNetworks {get; private set; }
    }
}