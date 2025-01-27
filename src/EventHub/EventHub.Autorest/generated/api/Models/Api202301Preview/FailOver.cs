// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Extensions;

    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.DoNotFormat]
    public partial class FailOver :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.IFailOver,
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.IFailOverInternal
    {

        /// <summary>
        /// Maximum time duration allowed complete data replication from primary to secondary. Use maximumGracePeriodInMins = 0: For
        /// Unplanned Geo-Failover, which switches the role between primary and secondary immediately. The data that is not being
        /// replicated yet will be discarded. Use maximumGracePeriodInMins > 0: For Planned Geo-Failover/DR Drill, continue replicating
        /// data until grace period expires. Any data that is not replicated during the grace period will be discarded. During the
        /// replication the namespace stops accepting any new publishing requests
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public int? MaximumGracePeriodInMin { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.IFailOverPropertiesInternal)Property).MaximumGracePeriodInMin; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.IFailOverPropertiesInternal)Property).MaximumGracePeriodInMin = value ?? default(int); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.IFailOverProperties Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.IFailOverInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.FailOverProperties()); set { {_property = value;} } }

        /// <summary>Query parameter for the new primary location after failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string PrimaryLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.IFailOverPropertiesInternal)Property).PrimaryLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.IFailOverPropertiesInternal)Property).PrimaryLocation = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.IFailOverProperties _property;

        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.IFailOverProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.FailOverProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="FailOver" /> instance.</summary>
        public FailOver()
        {

        }
    }
    public partial interface IFailOver :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Maximum time duration allowed complete data replication from primary to secondary. Use maximumGracePeriodInMins = 0: For
        /// Unplanned Geo-Failover, which switches the role between primary and secondary immediately. The data that is not being
        /// replicated yet will be discarded. Use maximumGracePeriodInMins > 0: For Planned Geo-Failover/DR Drill, continue replicating
        /// data until grace period expires. Any data that is not replicated during the grace period will be discarded. During the
        /// replication the namespace stops accepting any new publishing requests
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum time duration allowed complete data replication from primary to secondary. Use maximumGracePeriodInMins = 0: For Unplanned Geo-Failover, which switches the role between primary and secondary immediately. The data that is not being replicated yet will be discarded. Use maximumGracePeriodInMins > 0: For Planned Geo-Failover/DR Drill, continue replicating data until grace period expires.  Any data that is not replicated during the grace period will be discarded. During the replication the namespace stops accepting any new publishing requests",
        SerializedName = @"maximumGracePeriodInMins",
        PossibleTypes = new [] { typeof(int) })]
        int? MaximumGracePeriodInMin { get; set; }
        /// <summary>Query parameter for the new primary location after failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Query parameter for the new primary location after failover.",
        SerializedName = @"primaryLocation",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryLocation { get; set; }

    }
    internal partial interface IFailOverInternal

    {
        /// <summary>
        /// Maximum time duration allowed complete data replication from primary to secondary. Use maximumGracePeriodInMins = 0: For
        /// Unplanned Geo-Failover, which switches the role between primary and secondary immediately. The data that is not being
        /// replicated yet will be discarded. Use maximumGracePeriodInMins > 0: For Planned Geo-Failover/DR Drill, continue replicating
        /// data until grace period expires. Any data that is not replicated during the grace period will be discarded. During the
        /// replication the namespace stops accepting any new publishing requests
        /// </summary>
        int? MaximumGracePeriodInMin { get; set; }
        /// <summary>Query parameter for the new primary location after failover.</summary>
        string PrimaryLocation { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.IFailOverProperties Property { get; set; }

    }
}