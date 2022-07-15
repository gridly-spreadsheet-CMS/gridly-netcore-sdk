/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.30.0
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
    /// Defines ExportFileHeader
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExportFileHeader
    {
        /// <summary>
        /// Enum none for value: none
        /// </summary>
        [EnumMember(Value = "none")]
        none = 1,

        /// <summary>
        /// Enum columnName for value: columnName
        /// </summary>
        [EnumMember(Value = "columnName")]
        columnName = 2

    }

}
