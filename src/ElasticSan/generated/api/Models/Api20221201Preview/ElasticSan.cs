// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Extensions;

    /// <summary>Response for ElasticSan request.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.DoNotFormat]
    public partial class ElasticSan :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSan,
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.TrackedResource();

        /// <summary>Logical zone for Elastic San resource; example: ["1"].</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public string[] AvailabilityZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).AvailabilityZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).AvailabilityZone = value ?? null /* arrayOf */; }

        /// <summary>Base size of the Elastic San appliance in TiB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public long BaseSizeTiB { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).BaseSizeTiB; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).BaseSizeTiB = value ; }

        /// <summary>Extended size of the Elastic San appliance in TiB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public long ExtendedCapacitySizeTiB { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).ExtendedCapacitySizeTiB; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).ExtendedCapacitySizeTiB = value ; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).Id; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Internal Acessors for PrivateEndpointConnection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IPrivateEndpointConnection[] Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanInternal.PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).PrivateEndpointConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).PrivateEndpointConnection = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanProperties Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.ElasticSanProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.ProvisioningStates? Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.ISku Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanInternal.Sku { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).Sku = value; }

        /// <summary>Internal Acessors for TotalIops</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanInternal.TotalIops { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).TotalIops; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).TotalIops = value; }

        /// <summary>Internal Acessors for TotalMBps</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanInternal.TotalMBps { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).TotalMBps; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).TotalMBps = value; }

        /// <summary>Internal Acessors for TotalSizeTiB</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanInternal.TotalSizeTiB { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).TotalSizeTiB; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).TotalSizeTiB = value; }

        /// <summary>Internal Acessors for TotalVolumeSizeGiB</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanInternal.TotalVolumeSizeGiB { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).TotalVolumeSizeGiB; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).TotalVolumeSizeGiB = value; }

        /// <summary>Internal Acessors for VolumeGroupCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanInternal.VolumeGroupCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).VolumeGroupCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).VolumeGroupCount = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).Name; }

        /// <summary>The list of Private Endpoint Connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IPrivateEndpointConnection[] PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).PrivateEndpointConnection; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanProperties _property;

        /// <summary>Properties of ElasticSan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.ElasticSanProperties()); set => this._property = value; }

        /// <summary>State of the operation on the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.ProvisioningStates? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).ProvisioningState; }

        /// <summary>The sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.SkuName SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).SkuName = value ; }

        /// <summary>The sku tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.SkuTier? SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).SkuTier; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).SkuTier = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.SkuTier)""); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.CreatedByType)""); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>Total Provisioned IOPS of the Elastic San appliance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public long? TotalIops { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).TotalIops; }

        /// <summary>Total Provisioned MBps Elastic San appliance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public long? TotalMBps { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).TotalMBps; }

        /// <summary>Total size of the Elastic San appliance in TB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public long? TotalSizeTiB { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).TotalSizeTiB; }

        /// <summary>Total size of the provisioned Volumes in GiB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public long? TotalVolumeSizeGiB { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).TotalVolumeSizeGiB; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.IResourceInternal)__trackedResource).Type; }

        /// <summary>Total number of volume groups in this Elastic San appliance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public long? VolumeGroupCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanPropertiesInternal)Property).VolumeGroupCount; }

        /// <summary>Creates an new <see cref="ElasticSan" /> instance.</summary>
        public ElasticSan()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Response for ElasticSan request.
    public partial interface IElasticSan :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.ITrackedResource
    {
        /// <summary>Logical zone for Elastic San resource; example: ["1"].</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Logical zone for Elastic San resource; example: [""1""].",
        SerializedName = @"availabilityZones",
        PossibleTypes = new [] { typeof(string) })]
        string[] AvailabilityZone { get; set; }
        /// <summary>Base size of the Elastic San appliance in TiB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Base size of the Elastic San appliance in TiB.",
        SerializedName = @"baseSizeTiB",
        PossibleTypes = new [] { typeof(long) })]
        long BaseSizeTiB { get; set; }
        /// <summary>Extended size of the Elastic San appliance in TiB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Extended size of the Elastic San appliance in TiB.",
        SerializedName = @"extendedCapacitySizeTiB",
        PossibleTypes = new [] { typeof(long) })]
        long ExtendedCapacitySizeTiB { get; set; }
        /// <summary>The list of Private Endpoint Connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of Private Endpoint Connections.",
        SerializedName = @"privateEndpointConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IPrivateEndpointConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IPrivateEndpointConnection[] PrivateEndpointConnection { get;  }
        /// <summary>State of the operation on the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"State of the operation on the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.ProvisioningStates) })]
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.ProvisioningStates? ProvisioningState { get;  }
        /// <summary>The sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The sku name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.SkuName) })]
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.SkuName SkuName { get; set; }
        /// <summary>The sku tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The sku tier.",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.SkuTier) })]
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.SkuTier? SkuTier { get; set; }
        /// <summary>Total Provisioned IOPS of the Elastic San appliance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total Provisioned IOPS of the Elastic San appliance.",
        SerializedName = @"totalIops",
        PossibleTypes = new [] { typeof(long) })]
        long? TotalIops { get;  }
        /// <summary>Total Provisioned MBps Elastic San appliance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total Provisioned MBps Elastic San appliance.",
        SerializedName = @"totalMBps",
        PossibleTypes = new [] { typeof(long) })]
        long? TotalMBps { get;  }
        /// <summary>Total size of the Elastic San appliance in TB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total size of the Elastic San appliance in TB.",
        SerializedName = @"totalSizeTiB",
        PossibleTypes = new [] { typeof(long) })]
        long? TotalSizeTiB { get;  }
        /// <summary>Total size of the provisioned Volumes in GiB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total size of the provisioned Volumes in GiB.",
        SerializedName = @"totalVolumeSizeGiB",
        PossibleTypes = new [] { typeof(long) })]
        long? TotalVolumeSizeGiB { get;  }
        /// <summary>Total number of volume groups in this Elastic San appliance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total number of volume groups in this Elastic San appliance.",
        SerializedName = @"volumeGroupCount",
        PossibleTypes = new [] { typeof(long) })]
        long? VolumeGroupCount { get;  }

    }
    /// Response for ElasticSan request.
    internal partial interface IElasticSanInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api30.ITrackedResourceInternal
    {
        /// <summary>Logical zone for Elastic San resource; example: ["1"].</summary>
        string[] AvailabilityZone { get; set; }
        /// <summary>Base size of the Elastic San appliance in TiB.</summary>
        long BaseSizeTiB { get; set; }
        /// <summary>Extended size of the Elastic San appliance in TiB.</summary>
        long ExtendedCapacitySizeTiB { get; set; }
        /// <summary>The list of Private Endpoint Connections.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IPrivateEndpointConnection[] PrivateEndpointConnection { get; set; }
        /// <summary>Properties of ElasticSan.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IElasticSanProperties Property { get; set; }
        /// <summary>State of the operation on the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.ProvisioningStates? ProvisioningState { get; set; }
        /// <summary>resource sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.ISku Sku { get; set; }
        /// <summary>The sku name.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.SkuName SkuName { get; set; }
        /// <summary>The sku tier.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.SkuTier? SkuTier { get; set; }
        /// <summary>Total Provisioned IOPS of the Elastic San appliance.</summary>
        long? TotalIops { get; set; }
        /// <summary>Total Provisioned MBps Elastic San appliance.</summary>
        long? TotalMBps { get; set; }
        /// <summary>Total size of the Elastic San appliance in TB.</summary>
        long? TotalSizeTiB { get; set; }
        /// <summary>Total size of the provisioned Volumes in GiB.</summary>
        long? TotalVolumeSizeGiB { get; set; }
        /// <summary>Total number of volume groups in this Elastic San appliance.</summary>
        long? VolumeGroupCount { get; set; }

    }
}