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
    /// A websocket reference
    /// </summary>
    public partial class WebSocketContainer
    {
        /// <summary>
        /// Initializes a new instance of the WebSocketContainer class.
        /// </summary>
        public WebSocketContainer() { }

        /// <summary>
        /// Initializes a new instance of the WebSocketContainer class.
        /// </summary>
        public WebSocketContainer(string url)
        {
            Url = url;
        }

        /// <summary>
        /// WebSocket URL
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
        }
    }
}