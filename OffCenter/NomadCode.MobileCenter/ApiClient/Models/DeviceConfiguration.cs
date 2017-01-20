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

    public partial class DeviceConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the DeviceConfiguration class.
        /// </summary>
        public DeviceConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the DeviceConfiguration class.
        /// </summary>
        public DeviceConfiguration(string name = default(string), Guid? id = default(Guid?), double? tier = default(double?), DeviceConfigurationImage image = default(DeviceConfigurationImage), DeviceModel model = default(DeviceModel), string os = default(string), string osName = default(string), double? marketShare = default(double?))
        {
            Name = name;
            Id = id;
            Tier = tier;
            Image = image;
            Model = model;
            Os = os;
            OsName = osName;
            MarketShare = marketShare;
        }

        /// <summary>
        /// The name of the device model and OS version
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The unique id of the device configuration
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// The tier
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public double? Tier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public DeviceConfigurationImage Image { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "model")]
        public DeviceModel Model { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "os")]
        public string Os { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "osName")]
        public string OsName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "marketShare")]
        public double? MarketShare { get; set; }

    }
}
