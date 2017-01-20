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
    /// A single symbol upload entity
    /// </summary>
    public partial class SymbolUpload
    {
        /// <summary>
        /// Initializes a new instance of the SymbolUpload class.
        /// </summary>
        public SymbolUpload() { }

        /// <summary>
        /// Initializes a new instance of the SymbolUpload class.
        /// </summary>
        public SymbolUpload(string symbolUploadId, string appId, string status, IList<Symbol> symbols = default(IList<Symbol>), string origin = default(string))
        {
            SymbolUploadId = symbolUploadId;
            AppId = appId;
            Status = status;
            Symbols = symbols;
            Origin = origin;
        }
        /// <summary>
        /// Static constructor for SymbolUpload class.
        /// </summary>
        static SymbolUpload()
        {
            SymbolType = "Apple";
        }

        /// <summary>
        /// The id for the current symbol upload
        /// </summary>
        [JsonProperty(PropertyName = "symbol_upload_id")]
        public string SymbolUploadId { get; set; }

        /// <summary>
        /// The application that this symbol upload belongs to
        /// </summary>
        [JsonProperty(PropertyName = "app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// The current status for the symbol upload. Possible values include:
        /// 'created', 'committed', 'aborted', 'processing', 'indexed',
        /// 'failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// The symbol ids
        /// </summary>
        [JsonProperty(PropertyName = "symbols")]
        public IList<Symbol> Symbols { get; set; }

        /// <summary>
        /// The origin of the symbol upload. Possible values include: 'User',
        /// 'System'
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// The type of the symbol for the current symbol upload
        /// </summary>
        [JsonProperty(PropertyName = "symbol_type")]
        public static string SymbolType { get; private set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (SymbolUploadId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SymbolUploadId");
            }
            if (AppId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AppId");
            }
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
            if (this.Symbols != null)
            {
                foreach (var element in this.Symbols)
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
