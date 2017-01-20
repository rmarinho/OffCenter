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

    public partial class AppRequest
    {
        /// <summary>
        /// Initializes a new instance of the AppRequest class.
        /// </summary>
        public AppRequest() { }

        /// <summary>
        /// Initializes a new instance of the AppRequest class.
        /// </summary>
        public AppRequest(string displayName, string os, string platform, string description = default(string), string name = default(string))
        {
            Description = description;
            DisplayName = displayName;
            Name = name;
            Os = os;
            Platform = platform;
        }

        /// <summary>
        /// A short text describing the app
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The descriptive name of the app. This can contain any characters
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The name of the app used in URLs
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The OS the app will be running on. Possible values include: 'iOS',
        /// 'Android'
        /// </summary>
        [JsonProperty(PropertyName = "os")]
        public string Os { get; set; }

        /// <summary>
        /// The platform of the app. Possible values include:
        /// 'Objective-C-Swift', 'Java', 'React-Native', 'Xamarin'
        /// </summary>
        [JsonProperty(PropertyName = "platform")]
        public string Platform { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Os == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Os");
            }
            if (Platform == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Platform");
            }
        }
    }
}
