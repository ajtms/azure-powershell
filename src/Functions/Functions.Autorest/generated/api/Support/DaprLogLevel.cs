// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>
    /// Sets the log level for the Dapr sidecar. Allowed values are debug, info, warn, error. Default is info.
    /// </summary>
    public partial struct DaprLogLevel :
        System.IEquatable<DaprLogLevel>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DaprLogLevel Debug = @"debug";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DaprLogLevel Error = @"error";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DaprLogLevel Info = @"info";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DaprLogLevel Warn = @"warn";

        /// <summary>the value for an instance of the <see cref="DaprLogLevel" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DaprLogLevel</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DaprLogLevel" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DaprLogLevel(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DaprLogLevel"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DaprLogLevel(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DaprLogLevel</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DaprLogLevel e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DaprLogLevel (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DaprLogLevel && Equals((DaprLogLevel)obj);
        }

        /// <summary>Returns hashCode for enum DaprLogLevel</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DaprLogLevel</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DaprLogLevel</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DaprLogLevel" />.</param>

        public static implicit operator DaprLogLevel(string value)
        {
            return new DaprLogLevel(value);
        }

        /// <summary>Implicit operator to convert DaprLogLevel to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DaprLogLevel" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DaprLogLevel e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DaprLogLevel</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DaprLogLevel e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DaprLogLevel e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DaprLogLevel</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DaprLogLevel e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DaprLogLevel e2)
        {
            return e2.Equals(e1);
        }
    }
}