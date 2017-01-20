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

    public partial class AppResponse
    {
        /// <summary>
        /// Initializes a new instance of the AppResponse class.
        /// </summary>
        public AppResponse() { }

        /// <summary>
        /// Initializes a new instance of the AppResponse class.
        /// </summary>
        public AppResponse(string id, string appSecret, string displayName, string name, string os, string platform, Owner owner, string description = default(string), string iconUrl = default(string), string azureSubscriptionId = default(string))
        {
            Id = id;
            AppSecret = appSecret;
            Description = description;
            DisplayName = displayName;
            Name = name;
            Os = os;
            Platform = platform;
            IconUrl = iconUrl;
            Owner = owner;
            AzureSubscriptionId = azureSubscriptionId;
        }

        /// <summary>
        /// The unique ID (UUID) of the app
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// A unique and secret key used to identify the app in communication
        /// with the ingestion endpoint for crash reporting and analytics
        /// </summary>
        [JsonProperty(PropertyName = "app_secret")]
        public string AppSecret { get; set; }

        /// <summary>
        /// The description of the app
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The display name of the app
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
        /// The string representation of the URL pointing to the app's icon
        /// </summary>
        [JsonProperty(PropertyName = "icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public Owner Owner { get; set; }

        /// <summary>
        /// The unique ID (UUID) of the Azure subscription associate with the
        /// app
        /// </summary>
        [JsonProperty(PropertyName = "azure_subscription_id")]
        public string AzureSubscriptionId { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (AppSecret == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AppSecret");
            }
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Os == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Os");
            }
            if (Platform == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Platform");
            }
            if (Owner == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Owner");
            }
            if (this.Owner != null)
            {
                this.Owner.Validate();
            }
        }
    }
}
