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
    /// Event property value counts during the time range in descending order
    /// </summary>
    public partial class EventPropertyValues
    {
        /// <summary>
        /// Initializes a new instance of the EventPropertyValues class.
        /// </summary>
        public EventPropertyValues() { }

        /// <summary>
        /// Initializes a new instance of the EventPropertyValues class.
        /// </summary>
        public EventPropertyValues(long? total = default(long?), IList<EventPropertyValue> values = default(IList<EventPropertyValue>))
        {
            Total = total;
            Values = values;
        }

        /// <summary>
        /// The total property value counts
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public long? Total { get; set; }

        /// <summary>
        /// The event property values
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<EventPropertyValue> Values { get; set; }

    }
}
