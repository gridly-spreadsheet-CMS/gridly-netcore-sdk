/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.13.0
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
    /// SetCell
    /// </summary>
    [DataContract(Name = "SetCell")]
    public partial class SetCell : IEquatable<SetCell>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetCell" /> class.
        /// </summary>
        /// <param name="columnId">columnId.</param>
        /// <param name="referencedIds">referencedIds.</param>
        /// <param name="value">value.</param>
        public SetCell(string columnId = default(string), List<string> referencedIds = default(List<string>), Object value = default(Object))
        {
            this.ColumnId = columnId;
            this.ReferencedIds = referencedIds;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets ColumnId
        /// </summary>
        [DataMember(Name = "columnId", EmitDefaultValue = false)]
        public string ColumnId { get; set; }

        /// <summary>
        /// Gets or Sets ReferencedIds
        /// </summary>
        [DataMember(Name = "referencedIds", EmitDefaultValue = false)]
        public List<string> ReferencedIds { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public Object Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetCell {\n");
            sb.Append("  ColumnId: ").Append(ColumnId).Append("\n");
            sb.Append("  ReferencedIds: ").Append(ReferencedIds).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as SetCell);
        }

        /// <summary>
        /// Returns true if SetCell instances are equal
        /// </summary>
        /// <param name="input">Instance of SetCell to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetCell input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ColumnId == input.ColumnId ||
                    (this.ColumnId != null &&
                    this.ColumnId.Equals(input.ColumnId))
                ) && 
                (
                    this.ReferencedIds == input.ReferencedIds ||
                    this.ReferencedIds != null &&
                    input.ReferencedIds != null &&
                    this.ReferencedIds.SequenceEqual(input.ReferencedIds)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.ColumnId != null)
                    hashCode = hashCode * 59 + this.ColumnId.GetHashCode();
                if (this.ReferencedIds != null)
                    hashCode = hashCode * 59 + this.ReferencedIds.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
