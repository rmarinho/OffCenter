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

    public partial class DeviceConfigurationImage
    {
        /// <summary>
        /// Initializes a new instance of the DeviceConfigurationImage class.
        /// </summary>
        public DeviceConfigurationImage() { }

        /// <summary>
        /// Initializes a new instance of the DeviceConfigurationImage class.
        /// </summary>
        public DeviceConfigurationImage(string full = default(string), string thumb = default(string))
        {
            Full = full;
            Thumb = thumb;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "full")]
        public string Full { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb")]
        public string Thumb { get; set; }

    }
}
