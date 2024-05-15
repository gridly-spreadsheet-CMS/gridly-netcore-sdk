/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 4.33.0
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
    /// Defines ImportOption
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImportOption
    {
        /// <summary>
        /// Enum ADD for value: ADD
        /// </summary>
        [EnumMember(Value = "ADD")]
        ADD = 1,

        /// <summary>
        /// Enum UPDATE for value: UPDATE
        /// </summary>
        [EnumMember(Value = "UPDATE")]
        UPDATE = 2,

        /// <summary>
        /// Enum UPDATEONLY for value: UPDATE_ONLY
        /// </summary>
        [EnumMember(Value = "UPDATE_ONLY")]
        UPDATEONLY = 3

    }

}
