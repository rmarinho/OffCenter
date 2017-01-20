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

    public partial class DistributionGroupWithUsersResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DistributionGroupWithUsersResponse class.
        /// </summary>
        public DistributionGroupWithUsersResponse() { }

        /// <summary>
        /// Initializes a new instance of the
        /// DistributionGroupWithUsersResponse class.
        /// </summary>
        public DistributionGroupWithUsersResponse(string id, string name, IList<DistributionGroupUserGetResponse> users, double totalUserCount)
        {
            Id = id;
            Name = name;
            Users = users;
            TotalUserCount = totalUserCount;
        }

        /// <summary>
        /// The unique ID of the distribution group
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the distribution group used in URLs
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The distribution group users
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<DistributionGroupUserGetResponse> Users { get; set; }

        /// <summary>
        /// The count of users in the distribution group
        /// </summary>
        [JsonProperty(PropertyName = "total_user_count")]
        public double TotalUserCount { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Users == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Users");
            }
            if (this.Users != null)
            {
                foreach (var element in this.Users)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
