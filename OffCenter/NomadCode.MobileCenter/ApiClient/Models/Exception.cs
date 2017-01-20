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
    /// a exception
    /// </summary>
    public partial class Exception
    {
        /// <summary>
        /// Initializes a new instance of the Exception class.
        /// </summary>
        public Exception() { }

        /// <summary>
        /// Initializes a new instance of the Exception class.
        /// </summary>
        public Exception(IList<StackFrame> frames, string reason = default(string), string type = default(string), bool? relevant = default(bool?), IList<Exception> innerExceptions = default(IList<Exception>))
        {
            Reason = reason;
            Type = type;
            Frames = frames;
            Relevant = relevant;
            InnerExceptions = innerExceptions;
        }

        /// <summary>
        /// Reason of the exception
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Type of the exception (NSSomethingException, NullPointerException)
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// frames of the excetpion
        /// </summary>
        [JsonProperty(PropertyName = "frames")]
        public IList<StackFrame> Frames { get; set; }

        /// <summary>
        /// relevant exception (crashed)
        /// </summary>
        [JsonProperty(PropertyName = "relevant")]
        public bool? Relevant { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inner_exceptions")]
        public IList<Exception> InnerExceptions { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Frames == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Frames");
            }
            if (this.Frames != null)
            {
                foreach (var element in this.Frames)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.InnerExceptions != null)
            {
                foreach (var element1 in this.InnerExceptions)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}