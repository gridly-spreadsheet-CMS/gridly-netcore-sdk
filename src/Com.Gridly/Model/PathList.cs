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
    /// PathList
    /// </summary>
    [DataContract(Name = "PathList")]
    public partial class PathList : IEquatable<PathList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PathList" /> class.
        /// </summary>
        /// <param name="paths">paths.</param>
        public PathList(List<string> paths = default(List<string>))
        {
            this.Paths = paths;
        }

        /// <summary>
        /// Gets or Sets Paths
        /// </summary>
        [DataMember(Name = "paths", EmitDefaultValue = true)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PathList {\n");
            sb.Append("  Paths: ").Append(Paths).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PathList);
        }

        /// <summary>
        /// Returns true if PathList instances are equal
        /// </summary>
        /// <param name="input">Instance of PathList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PathList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Paths == input.Paths ||
                    this.Paths != null &&
                    input.Paths != null &&
                    this.Paths.SequenceEqual(input.Paths)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Paths != null)
                {
                    hashCode = (hashCode * 59) + this.Paths.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
