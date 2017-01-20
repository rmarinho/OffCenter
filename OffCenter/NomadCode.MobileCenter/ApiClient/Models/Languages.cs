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

    public partial class Languages
    {
        /// <summary>
        /// Initializes a new instance of the Languages class.
        /// </summary>
        public Languages() { }

        /// <summary>
        /// Initializes a new instance of the Languages class.
        /// </summary>
        public Languages(long? total = default(long?), IList<Language> languagesProperty = default(IList<Language>))
        {
            Total = total;
            LanguagesProperty = languagesProperty;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public long? Total { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "languages")]
        public IList<Language> LanguagesProperty { get; set; }

    }
}
