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

    public partial class EventModel
    {
        /// <summary>
        /// Initializes a new instance of the EventModel class.
        /// </summary>
        public EventModel() { }

        /// <summary>
        /// Initializes a new instance of the EventModel class.
        /// </summary>
        public EventModel(string id = default(string), string name = default(string), long? deviceCount = default(long?), long? previousDeviceCount = default(long?), long? count = default(long?), long? previousCount = default(long?), long? countPerDevice = default(long?), long? countPerSession = default(long?))
        {
            Id = id;
            Name = name;
            DeviceCount = deviceCount;
            PreviousDeviceCount = previousDeviceCount;
            Count = count;
            PreviousCount = previousCount;
            CountPerDevice = countPerDevice;
            CountPerSession = countPerSession;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceCount")]
        public long? DeviceCount { get; set; }

        /// <summary>
        /// the device count of previous time range of the event
        /// </summary>
        [JsonProperty(PropertyName = "previous_device_count")]
        public long? PreviousDeviceCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }

        /// <summary>
        /// the event count of previous time range of the event
        /// </summary>
        [JsonProperty(PropertyName = "previous_count")]
        public long? PreviousCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "count_per_device")]
        public long? CountPerDevice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "count_per_session")]
        public long? CountPerSession { get; set; }

    }
}
