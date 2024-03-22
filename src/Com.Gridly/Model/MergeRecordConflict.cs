/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 4.29.1
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
    /// MergeRecordConflict
    /// </summary>
    [DataContract(Name = "MergeRecordConflict")]
    public partial class MergeRecordConflict : IEquatable<MergeRecordConflict>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeRecordConflict" /> class.
        /// </summary>
        /// <param name="cells">cells.</param>
        /// <param name="pathTag">pathTag.</param>
        /// <param name="recordId">recordId.</param>
        public MergeRecordConflict(List<MergeCellConflict> cells = default(List<MergeCellConflict>), string pathTag = default(string), string recordId = default(string))
        {
            this.Cells = cells;
            this.PathTag = pathTag;
            this.RecordId = recordId;
        }

        /// <summary>
        /// Gets or Sets Cells
        /// </summary>
        [DataMember(Name = "cells", EmitDefaultValue = true)]
        public List<MergeCellConflict> Cells { get; set; }

        /// <summary>
        /// Gets or Sets PathTag
        /// </summary>
        [DataMember(Name = "pathTag", EmitDefaultValue = true)]
        public string PathTag { get; set; }

        /// <summary>
        /// Gets or Sets RecordId
        /// </summary>
        [DataMember(Name = "recordId", EmitDefaultValue = true)]
        public string RecordId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MergeRecordConflict {\n");
            sb.Append("  Cells: ").Append(Cells).Append("\n");
            sb.Append("  PathTag: ").Append(PathTag).Append("\n");
            sb.Append("  RecordId: ").Append(RecordId).Append("\n");
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
            return this.Equals(input as MergeRecordConflict);
        }

        /// <summary>
        /// Returns true if MergeRecordConflict instances are equal
        /// </summary>
        /// <param name="input">Instance of MergeRecordConflict to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MergeRecordConflict input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cells == input.Cells ||
                    this.Cells != null &&
                    input.Cells != null &&
                    this.Cells.SequenceEqual(input.Cells)
                ) && 
                (
                    this.PathTag == input.PathTag ||
                    (this.PathTag != null &&
                    this.PathTag.Equals(input.PathTag))
                ) && 
                (
                    this.RecordId == input.RecordId ||
                    (this.RecordId != null &&
                    this.RecordId.Equals(input.RecordId))
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
                if (this.Cells != null)
                {
                    hashCode = (hashCode * 59) + this.Cells.GetHashCode();
                }
                if (this.PathTag != null)
                {
                    hashCode = (hashCode * 59) + this.PathTag.GetHashCode();
                }
                if (this.RecordId != null)
                {
                    hashCode = (hashCode * 59) + this.RecordId.GetHashCode();
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
