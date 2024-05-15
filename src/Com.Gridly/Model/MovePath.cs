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
    /// MovePath
    /// </summary>
    [DataContract(Name = "MovePath")]
    public partial class MovePath : IEquatable<MovePath>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MovePath" /> class.
        /// </summary>
        /// <param name="names">names.</param>
        /// <param name="fromParentPath">fromParentPath.</param>
        /// <param name="toParentPath">toParentPath.</param>
        /// <param name="moveBefore">moveBefore.</param>
        /// <param name="moveAfter">moveAfter.</param>
        public MovePath(List<string> names = default(List<string>), string fromParentPath = default(string), string toParentPath = default(string), string moveBefore = default(string), string moveAfter = default(string))
        {
            this.Names = names;
            this.FromParentPath = fromParentPath;
            this.ToParentPath = toParentPath;
            this.MoveBefore = moveBefore;
            this.MoveAfter = moveAfter;
        }

        /// <summary>
        /// Gets or Sets Names
        /// </summary>
        [DataMember(Name = "names", EmitDefaultValue = true)]
        public List<string> Names { get; set; }

        /// <summary>
        /// Gets or Sets FromParentPath
        /// </summary>
        [DataMember(Name = "fromParentPath", EmitDefaultValue = true)]
        public string FromParentPath { get; set; }

        /// <summary>
        /// Gets or Sets ToParentPath
        /// </summary>
        [DataMember(Name = "toParentPath", EmitDefaultValue = true)]
        public string ToParentPath { get; set; }

        /// <summary>
        /// Gets or Sets MoveBefore
        /// </summary>
        [DataMember(Name = "moveBefore", EmitDefaultValue = true)]
        public string MoveBefore { get; set; }

        /// <summary>
        /// Gets or Sets MoveAfter
        /// </summary>
        [DataMember(Name = "moveAfter", EmitDefaultValue = true)]
        public string MoveAfter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MovePath {\n");
            sb.Append("  Names: ").Append(Names).Append("\n");
            sb.Append("  FromParentPath: ").Append(FromParentPath).Append("\n");
            sb.Append("  ToParentPath: ").Append(ToParentPath).Append("\n");
            sb.Append("  MoveBefore: ").Append(MoveBefore).Append("\n");
            sb.Append("  MoveAfter: ").Append(MoveAfter).Append("\n");
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
            return this.Equals(input as MovePath);
        }

        /// <summary>
        /// Returns true if MovePath instances are equal
        /// </summary>
        /// <param name="input">Instance of MovePath to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MovePath input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Names == input.Names ||
                    this.Names != null &&
                    input.Names != null &&
                    this.Names.SequenceEqual(input.Names)
                ) && 
                (
                    this.FromParentPath == input.FromParentPath ||
                    (this.FromParentPath != null &&
                    this.FromParentPath.Equals(input.FromParentPath))
                ) && 
                (
                    this.ToParentPath == input.ToParentPath ||
                    (this.ToParentPath != null &&
                    this.ToParentPath.Equals(input.ToParentPath))
                ) && 
                (
                    this.MoveBefore == input.MoveBefore ||
                    (this.MoveBefore != null &&
                    this.MoveBefore.Equals(input.MoveBefore))
                ) && 
                (
                    this.MoveAfter == input.MoveAfter ||
                    (this.MoveAfter != null &&
                    this.MoveAfter.Equals(input.MoveAfter))
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
                if (this.Names != null)
                {
                    hashCode = (hashCode * 59) + this.Names.GetHashCode();
                }
                if (this.FromParentPath != null)
                {
                    hashCode = (hashCode * 59) + this.FromParentPath.GetHashCode();
                }
                if (this.ToParentPath != null)
                {
                    hashCode = (hashCode * 59) + this.ToParentPath.GetHashCode();
                }
                if (this.MoveBefore != null)
                {
                    hashCode = (hashCode * 59) + this.MoveBefore.GetHashCode();
                }
                if (this.MoveAfter != null)
                {
                    hashCode = (hashCode * 59) + this.MoveAfter.GetHashCode();
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
