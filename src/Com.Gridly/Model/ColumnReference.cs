/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.21.0
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
    /// ColumnReference
    /// </summary>
    [DataContract(Name = "ColumnReference")]
    public partial class ColumnReference : IEquatable<ColumnReference>, IValidatableObject
    {
        /// <summary>
        /// Defines SelectionType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SelectionTypeEnum
        {
            /// <summary>
            /// Enum SINGLE for value: SINGLE
            /// </summary>
            [EnumMember(Value = "SINGLE")]
            SINGLE = 1,

            /// <summary>
            /// Enum MULTIPLE for value: MULTIPLE
            /// </summary>
            [EnumMember(Value = "MULTIPLE")]
            MULTIPLE = 2

        }


        /// <summary>
        /// Gets or Sets SelectionType
        /// </summary>
        [DataMember(Name = "selectionType", EmitDefaultValue = false)]
        public SelectionTypeEnum? SelectionType { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ROW for value: ROW
            /// </summary>
            [EnumMember(Value = "ROW")]
            ROW = 1,

            /// <summary>
            /// Enum CELL for value: CELL
            /// </summary>
            [EnumMember(Value = "CELL")]
            CELL = 2

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnReference" /> class.
        /// </summary>
        /// <param name="column">column.</param>
        /// <param name="grid">grid.</param>
        /// <param name="selectionType">selectionType.</param>
        /// <param name="type">type.</param>
        public ColumnReference(ReferencedColumn column = default(ReferencedColumn), ReferencedGrid grid = default(ReferencedGrid), SelectionTypeEnum? selectionType = default(SelectionTypeEnum?), TypeEnum? type = default(TypeEnum?))
        {
            this.Column = column;
            this.Grid = grid;
            this.SelectionType = selectionType;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Column
        /// </summary>
        [DataMember(Name = "column", EmitDefaultValue = false)]
        public ReferencedColumn Column { get; set; }

        /// <summary>
        /// Gets or Sets Grid
        /// </summary>
        [DataMember(Name = "grid", EmitDefaultValue = false)]
        public ReferencedGrid Grid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ColumnReference {\n");
            sb.Append("  Column: ").Append(Column).Append("\n");
            sb.Append("  Grid: ").Append(Grid).Append("\n");
            sb.Append("  SelectionType: ").Append(SelectionType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ColumnReference);
        }

        /// <summary>
        /// Returns true if ColumnReference instances are equal
        /// </summary>
        /// <param name="input">Instance of ColumnReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ColumnReference input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Column == input.Column ||
                    (this.Column != null &&
                    this.Column.Equals(input.Column))
                ) && 
                (
                    this.Grid == input.Grid ||
                    (this.Grid != null &&
                    this.Grid.Equals(input.Grid))
                ) && 
                (
                    this.SelectionType == input.SelectionType ||
                    this.SelectionType.Equals(input.SelectionType)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Column != null)
                {
                    hashCode = (hashCode * 59) + this.Column.GetHashCode();
                }
                if (this.Grid != null)
                {
                    hashCode = (hashCode * 59) + this.Grid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SelectionType.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
