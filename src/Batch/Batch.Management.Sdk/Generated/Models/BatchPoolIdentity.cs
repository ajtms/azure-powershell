// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System.Linq;

    /// <summary>
    /// The identity of the Batch pool, if configured. If the pool identity is
    /// updated during update an existing pool, only the new vms which are created
    /// after the pool shrinks to 0 will have the updated identities
    /// </summary>
    public partial class BatchPoolIdentity
    {
        /// <summary>
        /// Initializes a new instance of the BatchPoolIdentity class.
        /// </summary>
        public BatchPoolIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchPoolIdentity class.
        /// </summary>

        /// <param name="type">The type of identity used for the Batch Pool.
        /// Possible values include: &#39;UserAssigned&#39;, &#39;None&#39;</param>

        /// <param name="userAssignedIdentities">The list of user identities associated with the Batch pool.
        /// </param>
        public BatchPoolIdentity(PoolIdentityType type, System.Collections.Generic.IDictionary<string, UserAssignedIdentities> userAssignedIdentities = default(System.Collections.Generic.IDictionary<string, UserAssignedIdentities>))

        {
            this.Type = type;
            this.UserAssignedIdentities = userAssignedIdentities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the type of identity used for the Batch Pool. Possible values include: &#39;UserAssigned&#39;, &#39;None&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public PoolIdentityType Type {get; set; }

        /// <summary>
        /// Gets or sets the list of user identities associated with the Batch pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "userAssignedIdentities")]
        public System.Collections.Generic.IDictionary<string, UserAssignedIdentities> UserAssignedIdentities {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {


        }
    }
}