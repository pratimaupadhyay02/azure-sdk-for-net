// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Cloud service properties. </summary>
    public partial class CloudServiceProperties
    {
        /// <summary> Initializes a new instance of CloudServiceProperties. </summary>
        public CloudServiceProperties()
        {
        }

        /// <summary> Initializes a new instance of CloudServiceProperties. </summary>
        /// <param name="packageUrl">
        /// Specifies a URL that refers to the location of the service package in the Blob service. The service package URL can be Shared Access Signature (SAS) URI from any storage account.
        /// 
        /// This is a write-only property and is not returned in GET calls.
        /// </param>
        /// <param name="configuration"> Specifies the XML service configuration (.cscfg) for the cloud service. </param>
        /// <param name="configurationUrl">
        /// Specifies a URL that refers to the location of the service configuration in the Blob service. The service package URL  can be Shared Access Signature (SAS) URI from any storage account.
        /// 
        /// This is a write-only property and is not returned in GET calls.
        /// </param>
        /// <param name="startCloudService">
        /// (Optional) Indicates whether to start the cloud service immediately after it is created. The default value is `true`.
        /// 
        /// If false, the service model is still deployed, but the code is not run immediately. Instead, the service is PoweredOff until you call Start, at which time the service will be started. A deployed service still incurs charges, even if it is poweredoff.
        /// </param>
        /// <param name="allowModelOverride">
        /// (Optional) Indicates whether the role sku properties (roleProfile.roles.sku) specified in the model/template should override the role instance count and vm size specified in the .cscfg and .csdef respectively.
        /// 
        /// The default value is `false`.
        /// </param>
        /// <param name="upgradeMode">
        /// Update mode for the cloud service. Role instances are allocated to update domains when the service is deployed. Updates can be initiated manually in each update domain or initiated automatically in all update domains.
        /// 
        /// Possible Values are &lt;br /&gt;&lt;br /&gt;**Auto**&lt;br /&gt;&lt;br /&gt;**Manual** &lt;br /&gt;&lt;br /&gt;**Simultaneous**&lt;br /&gt;&lt;br /&gt;
        /// 
        /// If not specified, the default value is Auto. If set to Manual, PUT UpdateDomain must be called to apply the update. If set to Auto, the update is automatically applied to each update domain in sequence.
        /// </param>
        /// <param name="roleProfile"> Describes the role profile for the cloud service. </param>
        /// <param name="osProfile"> Describes the OS profile for the cloud service. </param>
        /// <param name="networkProfile"> Network Profile for the cloud service. </param>
        /// <param name="extensionProfile"> Describes a cloud service extension profile. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="uniqueId"> The unique identifier for the cloud service. </param>
        internal CloudServiceProperties(string packageUrl, string configuration, string configurationUrl, bool? startCloudService, bool? allowModelOverride, CloudServiceUpgradeMode? upgradeMode, CloudServiceRoleProfile roleProfile, CloudServiceOsProfile osProfile, CloudServiceNetworkProfile networkProfile, CloudServiceExtensionProfile extensionProfile, string provisioningState, string uniqueId)
        {
            PackageUrl = packageUrl;
            Configuration = configuration;
            ConfigurationUrl = configurationUrl;
            StartCloudService = startCloudService;
            AllowModelOverride = allowModelOverride;
            UpgradeMode = upgradeMode;
            RoleProfile = roleProfile;
            OsProfile = osProfile;
            NetworkProfile = networkProfile;
            ExtensionProfile = extensionProfile;
            ProvisioningState = provisioningState;
            UniqueId = uniqueId;
        }

        /// <summary>
        /// Specifies a URL that refers to the location of the service package in the Blob service. The service package URL can be Shared Access Signature (SAS) URI from any storage account.
        /// 
        /// This is a write-only property and is not returned in GET calls.
        /// </summary>
        public string PackageUrl { get; set; }
        /// <summary> Specifies the XML service configuration (.cscfg) for the cloud service. </summary>
        public string Configuration { get; set; }
        /// <summary>
        /// Specifies a URL that refers to the location of the service configuration in the Blob service. The service package URL  can be Shared Access Signature (SAS) URI from any storage account.
        /// 
        /// This is a write-only property and is not returned in GET calls.
        /// </summary>
        public string ConfigurationUrl { get; set; }
        /// <summary>
        /// (Optional) Indicates whether to start the cloud service immediately after it is created. The default value is `true`.
        /// 
        /// If false, the service model is still deployed, but the code is not run immediately. Instead, the service is PoweredOff until you call Start, at which time the service will be started. A deployed service still incurs charges, even if it is poweredoff.
        /// </summary>
        public bool? StartCloudService { get; set; }
        /// <summary>
        /// (Optional) Indicates whether the role sku properties (roleProfile.roles.sku) specified in the model/template should override the role instance count and vm size specified in the .cscfg and .csdef respectively.
        /// 
        /// The default value is `false`.
        /// </summary>
        public bool? AllowModelOverride { get; set; }
        /// <summary>
        /// Update mode for the cloud service. Role instances are allocated to update domains when the service is deployed. Updates can be initiated manually in each update domain or initiated automatically in all update domains.
        /// 
        /// Possible Values are &lt;br /&gt;&lt;br /&gt;**Auto**&lt;br /&gt;&lt;br /&gt;**Manual** &lt;br /&gt;&lt;br /&gt;**Simultaneous**&lt;br /&gt;&lt;br /&gt;
        /// 
        /// If not specified, the default value is Auto. If set to Manual, PUT UpdateDomain must be called to apply the update. If set to Auto, the update is automatically applied to each update domain in sequence.
        /// </summary>
        public CloudServiceUpgradeMode? UpgradeMode { get; set; }
        /// <summary> Describes the role profile for the cloud service. </summary>
        public CloudServiceRoleProfile RoleProfile { get; set; }
        /// <summary> Describes the OS profile for the cloud service. </summary>
        public CloudServiceOsProfile OsProfile { get; set; }
        /// <summary> Network Profile for the cloud service. </summary>
        public CloudServiceNetworkProfile NetworkProfile { get; set; }
        /// <summary> Describes a cloud service extension profile. </summary>
        public CloudServiceExtensionProfile ExtensionProfile { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The unique identifier for the cloud service. </summary>
        public string UniqueId { get; }
    }
}
