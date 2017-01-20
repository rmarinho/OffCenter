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
    /// Summary single test run on Xamarin Test Cloud
    /// </summary>
    public partial class TestRunStatistics
    {
        /// <summary>
        /// Initializes a new instance of the TestRunStatistics class.
        /// </summary>
        public TestRunStatistics() { }

        /// <summary>
        /// Initializes a new instance of the TestRunStatistics class.
        /// </summary>
        public TestRunStatistics(double? devices = default(double?), double? devicesFinished = default(double?), double? devicesFailed = default(double?), double? total = default(double?), double? passed = default(double?), double? failed = default(double?), double? skipped = default(double?), double? peakMemory = default(double?), double? totalDeviceMinutes = default(double?))
        {
            Devices = devices;
            DevicesFinished = devicesFinished;
            DevicesFailed = devicesFailed;
            Total = total;
            Passed = passed;
            Failed = failed;
            Skipped = skipped;
            PeakMemory = peakMemory;
            TotalDeviceMinutes = totalDeviceMinutes;
        }

        /// <summary>
        /// Number of devices running the test
        /// </summary>
        [JsonProperty(PropertyName = "devices")]
        public double? Devices { get; set; }

        /// <summary>
        /// Number of finished devices
        /// </summary>
        [JsonProperty(PropertyName = "devicesFinished")]
        public double? DevicesFinished { get; set; }

        /// <summary>
        /// Number of failed devices
        /// </summary>
        [JsonProperty(PropertyName = "devicesFailed")]
        public double? DevicesFailed { get; set; }

        /// <summary>
        /// Number of tests in total
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public double? Total { get; set; }

        /// <summary>
        /// Number of passed tests
        /// </summary>
        [JsonProperty(PropertyName = "passed")]
        public double? Passed { get; set; }

        /// <summary>
        /// Number of failed tests
        /// </summary>
        [JsonProperty(PropertyName = "failed")]
        public double? Failed { get; set; }

        /// <summary>
        /// Number of skipped tests
        /// </summary>
        [JsonProperty(PropertyName = "skipped")]
        public double? Skipped { get; set; }

        /// <summary>
        /// The max amount of MB used during the test run
        /// </summary>
        [JsonProperty(PropertyName = "peakMemory")]
        public double? PeakMemory { get; set; }

        /// <summary>
        /// The number of minutes of device time the test has been runnign
        /// </summary>
        [JsonProperty(PropertyName = "totalDeviceMinutes")]
        public double? TotalDeviceMinutes { get; set; }

    }
}
