// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support
{

    /// <summary>The kind of the service.</summary>
    public partial struct FhirServiceKind :
        System.IEquatable<FhirServiceKind>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirServiceKind FhirR4 = @"fhir-R4";

        public static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirServiceKind FhirStu3 = @"fhir-Stu3";

        /// <summary>the value for an instance of the <see cref="FhirServiceKind" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to FhirServiceKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="FhirServiceKind" />.</param>
        internal static object CreateFrom(object value)
        {
            return new FhirServiceKind(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type FhirServiceKind</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirServiceKind e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type FhirServiceKind (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is FhirServiceKind && Equals((FhirServiceKind)obj);
        }

        /// <summary>Creates an instance of the <see cref="FhirServiceKind"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private FhirServiceKind(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum FhirServiceKind</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for FhirServiceKind</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to FhirServiceKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="FhirServiceKind" />.</param>

        public static implicit operator FhirServiceKind(string value)
        {
            return new FhirServiceKind(value);
        }

        /// <summary>Implicit operator to convert FhirServiceKind to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="FhirServiceKind" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirServiceKind e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum FhirServiceKind</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirServiceKind e1, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirServiceKind e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum FhirServiceKind</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirServiceKind e1, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirServiceKind e2)
        {
            return e2.Equals(e1);
        }
    }
}