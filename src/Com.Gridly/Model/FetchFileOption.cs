/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 4.27.1
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
    /// Defines FetchFileOption
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FetchFileOption
    {
        /// <summary>
        /// Enum all for value: all
        /// </summary>
        [EnumMember(Value = "all")]
        all = 1,

        /// <summary>
        /// Enum id for value: id
        /// </summary>
        [EnumMember(Value = "id")]
        id = 2,

        /// <summary>
        /// Enum name for value: name
        /// </summary>
        [EnumMember(Value = "name")]
        name = 3

    }

}
