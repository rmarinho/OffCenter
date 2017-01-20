// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace NomadCode.MobileCenter.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Basic information on a pacakge
    /// </summary>
    public partial class BasicPackageDetails
    {
        /// <summary>
        /// Initializes a new instance of the BasicPackageDetails class.
        /// </summary>
        public BasicPackageDetails() { }

        /// <summary>
        /// Initializes a new instance of the BasicPackageDetails class.
        /// </summary>
        public BasicPackageDetails(string packageId = default(string), string version = default(string), string shortVersion = default(string), string uploadedAt = default(string), IList<DistributionGroup> distributionGroups = default(IList<DistributionGroup>))
        {
            PackageId = packageId;
            Version = version;
            ShortVersion = shortVersion;
            UploadedAt = uploadedAt;
            DistributionGroups = distributionGroups;
        }

        /// <summary>
        /// ID identifying this unique package.
        /// </summary>
        [JsonProperty(PropertyName = "package_id")]
        public string PackageId { get; set; }

        /// <summary>
        /// The package's version.&lt;br&gt;
        /// For iOS: CFBundleVersion from info.plist.&lt;br&gt;
        /// For Android: android:versionCode from AppManifest.xml.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// The package's short version.&lt;br&gt;
        /// For iOS: CFBundleShortVersionString from info.plist.&lt;br&gt;
        /// For Android: android:versionName from AppManifest.xml.
        /// </summary>
        [JsonProperty(PropertyName = "short_version")]
        public string ShortVersion { get; set; }

        /// <summary>
        /// UTC time in ISO 8601 format of the uploaded time.
        /// </summary>
        [JsonProperty(PropertyName = "uploaded_at")]
        public string UploadedAt { get; set; }

        /// <summary>
        /// a list of distribution groups that are associated with this
        /// package.
        /// </summary>
        [JsonProperty(PropertyName = "distribution_groups")]
        public IList<DistributionGroup> DistributionGroups { get; set; }

    }
}
