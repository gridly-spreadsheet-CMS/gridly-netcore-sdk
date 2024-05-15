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
    /// View
    /// </summary>
    [DataContract(Name = "View")]
    public partial class View : IEquatable<View>, IValidatableObject
    {
        /// <summary>
        /// Defines GridStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GridStatusEnum
        {
            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 1,

            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 2,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 3,

            /// <summary>
            /// Enum Restoring for value: restoring
            /// </summary>
            [EnumMember(Value = "restoring")]
            Restoring = 4,

            /// <summary>
            /// Enum BackingUp for value: backingUp
            /// </summary>
            [EnumMember(Value = "backingUp")]
            BackingUp = 5,

            /// <summary>
            /// Enum Uploading for value: uploading
            /// </summary>
            [EnumMember(Value = "uploading")]
            Uploading = 6,

            /// <summary>
            /// Enum Importing for value: importing
            /// </summary>
            [EnumMember(Value = "importing")]
            Importing = 7,

            /// <summary>
            /// Enum Branching for value: branching
            /// </summary>
            [EnumMember(Value = "branching")]
            Branching = 8,

            /// <summary>
            /// Enum Merging for value: merging
            /// </summary>
            [EnumMember(Value = "merging")]
            Merging = 9,

            /// <summary>
            /// Enum Duplicating for value: duplicating
            /// </summary>
            [EnumMember(Value = "duplicating")]
            Duplicating = 10,

            /// <summary>
            /// Enum ClearingRecords for value: clearingRecords
            /// </summary>
            [EnumMember(Value = "clearingRecords")]
            ClearingRecords = 11,

            /// <summary>
            /// Enum Copying for value: copying
            /// </summary>
            [EnumMember(Value = "copying")]
            Copying = 12

        }


        /// <summary>
        /// Gets or Sets GridStatus
        /// </summary>
        [DataMember(Name = "gridStatus", EmitDefaultValue = true)]
        public GridStatusEnum? GridStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="View" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="columns">columns.</param>
        /// <param name="gridId">gridId.</param>
        /// <param name="gridStatus">gridStatus.</param>
        /// <param name="name">name.</param>
        /// <param name="records">records.</param>
        public View(string id = default(string), List<ViewColumn> columns = default(List<ViewColumn>), string gridId = default(string), GridStatusEnum? gridStatus = default(GridStatusEnum?), string name = default(string), List<Record> records = default(List<Record>))
        {
            this.Id = id;
            this.Columns = columns;
            this.GridId = gridId;
            this.GridStatus = gridStatus;
            this.Name = name;
            this.Records = records;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [DataMember(Name = "columns", EmitDefaultValue = true)]
        public List<ViewColumn> Columns { get; set; }

        /// <summary>
        /// Gets or Sets GridId
        /// </summary>
        [DataMember(Name = "gridId", EmitDefaultValue = true)]
        public string GridId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name = "records", EmitDefaultValue = true)]
        public List<Record> Records { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class View {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  GridId: ").Append(GridId).Append("\n");
            sb.Append("  GridStatus: ").Append(GridStatus).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
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
            return this.Equals(input as View);
        }

        /// <summary>
        /// Returns true if View instances are equal
        /// </summary>
        /// <param name="input">Instance of View to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(View input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Columns == input.Columns ||
                    this.Columns != null &&
                    input.Columns != null &&
                    this.Columns.SequenceEqual(input.Columns)
                ) && 
                (
                    this.GridId == input.GridId ||
                    (this.GridId != null &&
                    this.GridId.Equals(input.GridId))
                ) && 
                (
                    this.GridStatus == input.GridStatus ||
                    this.GridStatus.Equals(input.GridStatus)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Columns != null)
                {
                    hashCode = (hashCode * 59) + this.Columns.GetHashCode();
                }
                if (this.GridId != null)
                {
                    hashCode = (hashCode * 59) + this.GridId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GridStatus.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Records != null)
                {
                    hashCode = (hashCode * 59) + this.Records.GetHashCode();
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
