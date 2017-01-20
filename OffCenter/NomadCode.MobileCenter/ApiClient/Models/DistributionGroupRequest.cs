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

    public partial class DistributionGroupRequest
    {
        /// <summary>
        /// Initializes a new instance of the DistributionGroupRequest class.
        /// </summary>
        public DistributionGroupRequest() { }

        /// <summary>
        /// Initializes a new instance of the DistributionGroupRequest class.
        /// </summary>
        public DistributionGroupRequest(string name)
        {
            Name = name;
        }

        /// <summary>
        /// The name of the distribution group
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
