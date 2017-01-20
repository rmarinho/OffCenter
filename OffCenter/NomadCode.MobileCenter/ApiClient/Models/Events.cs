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

    public partial class Events
    {
        /// <summary>
        /// Initializes a new instance of the Events class.
        /// </summary>
        public Events() { }

        /// <summary>
        /// Initializes a new instance of the Events class.
        /// </summary>
        public Events(IList<EventModel> eventsProperty = default(IList<EventModel>), long? total = default(long?), long? totalDevices = default(long?))
        {
            EventsProperty = eventsProperty;
            Total = total;
            TotalDevices = totalDevices;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IList<EventModel> EventsProperty { get; set; }

        /// <summary>
        /// the total count of events
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public long? Total { get; set; }

        /// <summary>
        /// the active device over this period
        /// </summary>
        [JsonProperty(PropertyName = "total_devices")]
        public long? TotalDevices { get; set; }

    }
}
