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

    public partial class CrashGroupModel
    {
        /// <summary>
        /// Initializes a new instance of the CrashGroupModel class.
        /// </summary>
        public CrashGroupModel() { }

        /// <summary>
        /// Initializes a new instance of the CrashGroupModel class.
        /// </summary>
        public CrashGroupModel(string modelName = default(string), long? crashCount = default(long?))
        {
            ModelName = modelName;
            CrashCount = crashCount;
        }

        /// <summary>
        /// model's name
        /// </summary>
        [JsonProperty(PropertyName = "model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// count of model
        /// </summary>
        [JsonProperty(PropertyName = "crash_count")]
        public long? CrashCount { get; set; }

    }
}
