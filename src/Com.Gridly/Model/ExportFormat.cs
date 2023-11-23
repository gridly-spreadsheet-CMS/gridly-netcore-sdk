/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 4.21.5
 * Contact: support@gridly.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Com.Gridly.Client.OpenAPIDateConverter;

namespace Com.Gridly.Model
{
    /// <summary>
    /// Defines ExportFormat
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExportFormat
    {
        /// <summary>
        /// Enum Tmx for value: tmx
        /// </summary>
        [EnumMember(Value = "tmx")]
        Tmx = 1,

        /// <summary>
        /// Enum Csv for value: csv
        /// </summary>
        [EnumMember(Value = "csv")]
        Csv = 2,

        /// <summary>
        /// Enum Xlsx for value: xlsx
        /// </summary>
        [EnumMember(Value = "xlsx")]
        Xlsx = 3

    }

}
