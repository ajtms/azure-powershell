// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    /// <summary>Request details needed to get the plans statuses</summary>
    public partial class RequestDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestDetailsInternal
    {

        /// <summary>Backing field for <see cref="PlanId" /> property.</summary>
        private System.Collections.Generic.List<string> _planId;

        /// <summary>Current plans list</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> PlanId { get => this._planId; set => this._planId = value; }

        /// <summary>Backing field for <see cref="PublisherId" /> property.</summary>
        private string _publisherId;

        /// <summary>The offer's publisher id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string PublisherId { get => this._publisherId; set => this._publisherId = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>Gets or sets the subscription id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="RequestDetails" /> instance.</summary>
        public RequestDetails()
        {

        }
    }
    /// Request details needed to get the plans statuses
    public partial interface IRequestDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.IJsonSerializable
    {
        /// <summary>Current plans list</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Current plans list",
        SerializedName = @"planIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> PlanId { get; set; }
        /// <summary>The offer's publisher id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The offer's publisher id",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        string PublisherId { get; set; }
        /// <summary>Gets or sets the subscription id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the subscription id",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    /// Request details needed to get the plans statuses
    internal partial interface IRequestDetailsInternal

    {
        /// <summary>Current plans list</summary>
        System.Collections.Generic.List<string> PlanId { get; set; }
        /// <summary>The offer's publisher id</summary>
        string PublisherId { get; set; }
        /// <summary>Gets or sets the subscription id</summary>
        string SubscriptionId { get; set; }

    }
}