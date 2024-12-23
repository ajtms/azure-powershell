// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>Scale and concurrency settings for the function app triggers.</summary>
    public partial class FunctionsScaleAndConcurrencyTriggers :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggers,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggersInternal
    {

        /// <summary>Backing field for <see cref="Http" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggersHttp _http;

        /// <summary>Scale and concurrency settings for the HTTP trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggersHttp Http { get => (this._http = this._http ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsScaleAndConcurrencyTriggersHttp()); set => this._http = value; }

        /// <summary>The maximum number of concurrent HTTP trigger invocations per instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public float? HttpPerInstanceConcurrency { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggersHttpInternal)Http).PerInstanceConcurrency; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggersHttpInternal)Http).PerInstanceConcurrency = value ?? default(float); }

        /// <summary>Internal Acessors for Http</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggersHttp Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggersInternal.Http { get => (this._http = this._http ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsScaleAndConcurrencyTriggersHttp()); set { {_http = value;} } }

        /// <summary>Creates an new <see cref="FunctionsScaleAndConcurrencyTriggers" /> instance.</summary>
        public FunctionsScaleAndConcurrencyTriggers()
        {

        }
    }
    /// Scale and concurrency settings for the function app triggers.
    public partial interface IFunctionsScaleAndConcurrencyTriggers :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>The maximum number of concurrent HTTP trigger invocations per instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum number of concurrent HTTP trigger invocations per instance.",
        SerializedName = @"perInstanceConcurrency",
        PossibleTypes = new [] { typeof(float) })]
        float? HttpPerInstanceConcurrency { get; set; }

    }
    /// Scale and concurrency settings for the function app triggers.
    internal partial interface IFunctionsScaleAndConcurrencyTriggersInternal

    {
        /// <summary>Scale and concurrency settings for the HTTP trigger.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggersHttp Http { get; set; }
        /// <summary>The maximum number of concurrent HTTP trigger invocations per instance.</summary>
        float? HttpPerInstanceConcurrency { get; set; }

    }
}