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

    public partial class Model
    {
        /// <summary>
        /// Initializes a new instance of the Model class.
        /// </summary>
        public Model() { }

        /// <summary>
        /// Initializes a new instance of the Model class.
        /// </summary>
        public Model(string modelName = default(string), long? count = default(long?), long? previousCount = default(long?))
        {
            ModelName = modelName;
            Count = count;
            PreviousCount = previousCount;
        }

        /// <summary>
        /// model's name
        /// </summary>
        [JsonProperty(PropertyName = "model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// count current of model
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }

        /// <summary>
        /// count of previous model
        /// </summary>
        [JsonProperty(PropertyName = "previous_count")]
        public long? PreviousCount { get; set; }

    }
}
