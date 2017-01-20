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
    /// Defines headers for createTestRun operation.
    /// </summary>
    public partial class TestCreateTestRunHeaders
    {
        /// <summary>
        /// Initializes a new instance of the TestCreateTestRunHeaders class.
        /// </summary>
        public TestCreateTestRunHeaders() { }

        /// <summary>
        /// Initializes a new instance of the TestCreateTestRunHeaders class.
        /// </summary>
        public TestCreateTestRunHeaders(string location = default(string))
        {
            Location = location;
        }

        /// <summary>
        /// Relative URL that points to the test run
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
