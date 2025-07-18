// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class TriggerPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerPropertiesAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerPropertiesAutoGeneratedInternal
    {

        /// <summary>Backing field for <see cref="CreatedAt" /> property.</summary>
        private global::System.DateTime? _createdAt;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedAt { get => this._createdAt; }

        /// <summary>Backing field for <see cref="IncrementalScanStartTime" /> property.</summary>
        private global::System.DateTime? _incrementalScanStartTime;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public global::System.DateTime? IncrementalScanStartTime { get => this._incrementalScanStartTime; set => this._incrementalScanStartTime = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public int? Interval { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).Interval; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).Interval = value ?? default(int); }

        /// <summary>Backing field for <see cref="LastModifiedAt" /> property.</summary>
        private global::System.DateTime? _lastModifiedAt;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public global::System.DateTime? LastModifiedAt { get => this._lastModifiedAt; }

        /// <summary>Backing field for <see cref="LastScheduled" /> property.</summary>
        private global::System.DateTime? _lastScheduled;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public global::System.DateTime? LastScheduled { get => this._lastScheduled; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerPropertiesAutoGeneratedInternal.CreatedAt { get => this._createdAt; set { {_createdAt = value;} } }

        /// <summary>Internal Acessors for LastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerPropertiesAutoGeneratedInternal.LastModifiedAt { get => this._lastModifiedAt; set { {_lastModifiedAt = value;} } }

        /// <summary>Internal Acessors for LastScheduled</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerPropertiesAutoGeneratedInternal.LastScheduled { get => this._lastScheduled; set { {_lastScheduled = value;} } }

        /// <summary>Internal Acessors for Recurrence</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerPropertiesRecurrence Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerPropertiesAutoGeneratedInternal.Recurrence { get => (this._recurrence = this._recurrence ?? new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.TriggerPropertiesRecurrence()); set { {_recurrence = value;} } }

        /// <summary>Internal Acessors for RecurrenceSchedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceSchedule Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerPropertiesAutoGeneratedInternal.RecurrenceSchedule { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).Schedule; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).Schedule = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Recurrence" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerPropertiesRecurrence _recurrence;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerPropertiesRecurrence Recurrence { get => (this._recurrence = this._recurrence ?? new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.TriggerPropertiesRecurrence()); set => this._recurrence = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public global::System.DateTime? RecurrenceEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).EndTime = value ?? default(global::System.DateTime); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public string RecurrenceFrequency { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).Frequency; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).Frequency = value ?? null; }

        /// <summary>Backing field for <see cref="RecurrenceInterval" /> property.</summary>
        private string _recurrenceInterval;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public string RecurrenceInterval { get => this._recurrenceInterval; set => this._recurrenceInterval = value; }

        /// <summary>Dictionary of <any></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleAdditionalProperties RecurrenceScheduleAdditionalProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).ScheduleAdditionalProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).ScheduleAdditionalProperty = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<int> RecurrenceScheduleHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).ScheduleHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).ScheduleHour = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<int> RecurrenceScheduleMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).ScheduleMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).ScheduleMinute = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<int> RecurrenceScheduleMonthDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).ScheduleMonthDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).ScheduleMonthDay = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleOccurrence> RecurrenceScheduleMonthlyOccurrence { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).ScheduleMonthlyOccurrence; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).ScheduleMonthlyOccurrence = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> RecurrenceScheduleWeekDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).ScheduleWeekDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).ScheduleWeekDay = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public global::System.DateTime? RecurrenceStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).StartTime = value ?? default(global::System.DateTime); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public string RecurrenceTimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).TimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)Recurrence).TimeZone = value ?? null; }

        /// <summary>Backing field for <see cref="ScanLevel" /> property.</summary>
        private string _scanLevel;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public string ScanLevel { get => this._scanLevel; set => this._scanLevel = value; }

        /// <summary>Creates an new <see cref="TriggerPropertiesAutoGenerated" /> instance.</summary>
        public TriggerPropertiesAutoGenerated()
        {

        }
    }
    public partial interface ITriggerPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedAt { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"incrementalScanStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? IncrementalScanStartTime { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"interval",
        PossibleTypes = new [] { typeof(int) })]
        int? Interval { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastModifiedAt { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"",
        SerializedName = @"lastScheduled",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastScheduled { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RecurrenceEndTime { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"frequency",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PSArgumentCompleterAttribute("Week", "Month")]
        string RecurrenceFrequency { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"recurrenceInterval",
        PossibleTypes = new [] { typeof(string) })]
        string RecurrenceInterval { get; set; }
        /// <summary>Dictionary of <any></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Dictionary of <any>",
        SerializedName = @"additionalProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleAdditionalProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleAdditionalProperties RecurrenceScheduleAdditionalProperty { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"hours",
        PossibleTypes = new [] { typeof(int) })]
        System.Collections.Generic.List<int> RecurrenceScheduleHour { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"minutes",
        PossibleTypes = new [] { typeof(int) })]
        System.Collections.Generic.List<int> RecurrenceScheduleMinute { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"monthDays",
        PossibleTypes = new [] { typeof(int) })]
        System.Collections.Generic.List<int> RecurrenceScheduleMonthDay { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"monthlyOccurrences",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleOccurrence) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleOccurrence> RecurrenceScheduleMonthlyOccurrence { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"weekDays",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> RecurrenceScheduleWeekDay { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RecurrenceStartTime { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        string RecurrenceTimeZone { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"scanLevel",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PSArgumentCompleterAttribute("Full", "Incremental")]
        string ScanLevel { get; set; }

    }
    internal partial interface ITriggerPropertiesAutoGeneratedInternal

    {
        global::System.DateTime? CreatedAt { get; set; }

        global::System.DateTime? IncrementalScanStartTime { get; set; }

        int? Interval { get; set; }

        global::System.DateTime? LastModifiedAt { get; set; }

        global::System.DateTime? LastScheduled { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerPropertiesRecurrence Recurrence { get; set; }

        global::System.DateTime? RecurrenceEndTime { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PSArgumentCompleterAttribute("Week", "Month")]
        string RecurrenceFrequency { get; set; }

        string RecurrenceInterval { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceSchedule RecurrenceSchedule { get; set; }
        /// <summary>Dictionary of <any></summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleAdditionalProperties RecurrenceScheduleAdditionalProperty { get; set; }

        System.Collections.Generic.List<int> RecurrenceScheduleHour { get; set; }

        System.Collections.Generic.List<int> RecurrenceScheduleMinute { get; set; }

        System.Collections.Generic.List<int> RecurrenceScheduleMonthDay { get; set; }

        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleOccurrence> RecurrenceScheduleMonthlyOccurrence { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> RecurrenceScheduleWeekDay { get; set; }

        global::System.DateTime? RecurrenceStartTime { get; set; }

        string RecurrenceTimeZone { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PSArgumentCompleterAttribute("Full", "Incremental")]
        string ScanLevel { get; set; }

    }
}