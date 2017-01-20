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

    public partial class AvailableVersions
    {
        /// <summary>
        /// Initializes a new instance of the AvailableVersions class.
        /// </summary>
        public AvailableVersions() { }

        /// <summary>
        /// Initializes a new instance of the AvailableVersions class.
        /// </summary>
        public AvailableVersions(IList<string> versions = default(IList<string>), long? totalCount = default(long?))
        {
            Versions = versions;
            TotalCount = totalCount;
        }

        /// <summary>
        /// List of available versions.
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        public IList<string> Versions { get; set; }

        /// <summary>
        /// The full number of versions accross all pages.
        /// </summary>
        [JsonProperty(PropertyName = "total_count")]
        public long? TotalCount { get; set; }

    }
}