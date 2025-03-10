// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.PolicyInsights.Models
{

    /// <summary>
    /// Exception thrown for an invalid response with QueryFailure information.
    /// </summary>
    public partial class QueryFailureException : Microsoft.Rest.RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public Microsoft.Rest.HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public Microsoft.Rest.HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public QueryFailure Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the QueryFailureException class.
        /// </summary>
        public QueryFailureException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the QueryFailure class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public QueryFailureException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QueryFailure class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public QueryFailureException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}