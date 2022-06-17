/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.29.0
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
    /// Reference
    /// </summary>
    [DataContract(Name = "Reference")]
    public partial class Reference : IEquatable<Reference>, IValidatableObject
    {
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
        /// Initializes a new instance of the <see cref="Reference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Reference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Reference" /> class.
        /// </summary>
        /// <param name="gridId">gridId (required).</param>
        /// <param name="columnId">columnId (required).</param>
        /// <param name="type">type.</param>
        /// <param name="selectionType">selectionType.</param>
        public Reference(string gridId = default(string), string columnId = default(string), TypeEnum? type = default(TypeEnum?), SelectionTypeEnum? selectionType = default(SelectionTypeEnum?))
        {
            // to ensure "gridId" is required (not null)
            if (gridId == null)
            {
                throw new ArgumentNullException("gridId is a required property for Reference and cannot be null");
            }
            this.GridId = gridId;
            // to ensure "columnId" is required (not null)
            if (columnId == null)
            {
                throw new ArgumentNullException("columnId is a required property for Reference and cannot be null");
            }
            this.ColumnId = columnId;
            this.Type = type;
            this.SelectionType = selectionType;
        }

        /// <summary>
        /// Gets or Sets GridId
        /// </summary>
        [DataMember(Name = "gridId", IsRequired = true, EmitDefaultValue = false)]
        public string GridId { get; set; }

        /// <summary>
        /// Gets or Sets ColumnId
        /// </summary>
        [DataMember(Name = "columnId", IsRequired = true, EmitDefaultValue = false)]
        public string ColumnId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Reference {\n");
            sb.Append("  GridId: ").Append(GridId).Append("\n");
            sb.Append("  ColumnId: ").Append(ColumnId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SelectionType: ").Append(SelectionType).Append("\n");
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
            return this.Equals(input as Reference);
        }

        /// <summary>
        /// Returns true if Reference instances are equal
        /// </summary>
        /// <param name="input">Instance of Reference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Reference input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GridId == input.GridId ||
                    (this.GridId != null &&
                    this.GridId.Equals(input.GridId))
                ) && 
                (
                    this.ColumnId == input.ColumnId ||
                    (this.ColumnId != null &&
                    this.ColumnId.Equals(input.ColumnId))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.SelectionType == input.SelectionType ||
                    this.SelectionType.Equals(input.SelectionType)
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
                if (this.GridId != null)
                {
                    hashCode = (hashCode * 59) + this.GridId.GetHashCode();
                }
                if (this.ColumnId != null)
                {
                    hashCode = (hashCode * 59) + this.ColumnId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.SelectionType.GetHashCode();
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
