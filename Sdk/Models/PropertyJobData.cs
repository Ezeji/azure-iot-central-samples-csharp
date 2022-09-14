// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IoTCentral.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The property job data definition.
    /// </summary>
    public partial class PropertyJobData
    {
        /// <summary>
        /// Initializes a new instance of the PropertyJobData class.
        /// </summary>
        public PropertyJobData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PropertyJobData class.
        /// </summary>
        /// <param name="type">Type of the job data.</param>
        /// <param name="target">The device template which defines the target
        /// capability for the job.</param>
        /// <param name="path">The path to the target capability within the
        /// device template.</param>
        /// <param name="value">The value used to update the target capability,
        /// if any.</param>
        public PropertyJobData(string type, string target, string path, object value = default(object))
        {
            Type = type;
            Target = target;
            Path = path;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of the job data.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the device template which defines the target
        /// capability for the job.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets the path to the target capability within the device
        /// template.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the value used to update the target capability, if
        /// any.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

    }
}
