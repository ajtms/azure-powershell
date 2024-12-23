// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using System.Linq;

    /// <summary>
    /// Describes the input to the &#39;cancel&#39; and &#39;restart&#39; MongoDB migration
    /// commands
    /// </summary>
    public partial class MongoDbCommandInput
    {
        /// <summary>
        /// Initializes a new instance of the MongoDbCommandInput class.
        /// </summary>
        public MongoDbCommandInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MongoDbCommandInput class.
        /// </summary>

        /// <param name="objectName">The qualified name of a database or collection to act upon, or null to act
        /// upon the entire migration
        /// </param>
        public MongoDbCommandInput(string objectName = default(string))

        {
            this.ObjectName = objectName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the qualified name of a database or collection to act upon, or
        /// null to act upon the entire migration
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "objectName")]
        public string ObjectName {get; set; }
    }
}