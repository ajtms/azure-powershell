// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using System.Linq;

    /// <summary>
    /// The update gateway settings request parameters. Note either basic or entra
    /// user should be provided at a time.
    /// </summary>
    public partial class UpdateGatewaySettingsParameters
    {
        /// <summary>
        /// Initializes a new instance of the UpdateGatewaySettingsParameters class.
        /// </summary>
        public UpdateGatewaySettingsParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateGatewaySettingsParameters class.
        /// </summary>

        /// <param name="isCredentialEnabled">Indicates whether or not the gateway settings based authorization is
        /// enabled.
        /// </param>

        /// <param name="userName">The gateway settings user name.
        /// </param>

        /// <param name="password">The gateway settings user password.
        /// </param>

        /// <param name="restAuthEntraUsers">List of Entra users for gateway access.
        /// </param>
        public UpdateGatewaySettingsParameters(bool? isCredentialEnabled = default(bool?), string userName = default(string), string password = default(string), System.Collections.Generic.IList<EntraUserInfo> restAuthEntraUsers = default(System.Collections.Generic.IList<EntraUserInfo>))

        {
            this.IsCredentialEnabled = isCredentialEnabled;
            this.UserName = userName;
            this.Password = password;
            this.RestAuthEntraUsers = restAuthEntraUsers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets indicates whether or not the gateway settings based
        /// authorization is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "restAuthCredential.isEnabled")]
        public bool? IsCredentialEnabled {get; set; }

        /// <summary>
        /// Gets or sets the gateway settings user name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "restAuthCredential.username")]
        public string UserName {get; set; }

        /// <summary>
        /// Gets or sets the gateway settings user password.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "restAuthCredential.password")]
        public string Password {get; set; }

        /// <summary>
        /// Gets or sets list of Entra users for gateway access.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "restAuthEntraUsers")]
        public System.Collections.Generic.IList<EntraUserInfo> RestAuthEntraUsers {get; set; }
    }
}