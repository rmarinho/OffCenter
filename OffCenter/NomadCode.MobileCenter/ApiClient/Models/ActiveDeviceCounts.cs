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

    public partial class ActiveDeviceCounts
    {
        /// <summary>
        /// Initializes a new instance of the ActiveDeviceCounts class.
        /// </summary>
        public ActiveDeviceCounts() { }

        /// <summary>
        /// Initializes a new instance of the ActiveDeviceCounts class.
        /// </summary>
        public ActiveDeviceCounts(IList<DateTimeCounts> daily = default(IList<DateTimeCounts>), IList<DateTimeCounts> weekly = default(IList<DateTimeCounts>), IList<DateTimeCounts> monthly = default(IList<DateTimeCounts>))
        {
            Daily = daily;
            Weekly = weekly;
            Monthly = monthly;
        }

        /// <summary>
        /// the active device count for each interval
        /// </summary>
        [JsonProperty(PropertyName = "daily")]
        public IList<DateTimeCounts> Daily { get; set; }

        /// <summary>
        /// the active device count for each interval with a week's retention
        /// </summary>
        [JsonProperty(PropertyName = "weekly")]
        public IList<DateTimeCounts> Weekly { get; set; }

        /// <summary>
        /// the active device count for each interval with a month's retention
        /// </summary>
        [JsonProperty(PropertyName = "monthly")]
        public IList<DateTimeCounts> Monthly { get; set; }

    }
}