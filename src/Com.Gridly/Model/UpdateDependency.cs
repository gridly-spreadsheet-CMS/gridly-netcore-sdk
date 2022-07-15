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
    /// UpdateDependency
    /// </summary>
    [DataContract(Name = "UpdateDependency")]
    public partial class UpdateDependency : IEquatable<UpdateDependency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDependency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateDependency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDependency" /> class.
        /// </summary>
        /// <param name="newId">newId.</param>
        /// <param name="sourceColumnId">sourceColumnId (required).</param>
        /// <param name="targetColumnId">targetColumnId (required).</param>
        public UpdateDependency(string newId = default(string), string sourceColumnId = default(string), string targetColumnId = default(string))
        {
            // to ensure "sourceColumnId" is required (not null)
            if (sourceColumnId == null)
            {
                throw new ArgumentNullException("sourceColumnId is a required property for UpdateDependency and cannot be null");
            }
            this.SourceColumnId = sourceColumnId;
            // to ensure "targetColumnId" is required (not null)
            if (targetColumnId == null)
            {
                throw new ArgumentNullException("targetColumnId is a required property for UpdateDependency and cannot be null");
            }
            this.TargetColumnId = targetColumnId;
            this.NewId = newId;
        }

        /// <summary>
        /// Gets or Sets NewId
        /// </summary>
        [DataMember(Name = "newId", EmitDefaultValue = false)]
        public string NewId { get; set; }

        /// <summary>
        /// Gets or Sets SourceColumnId
        /// </summary>
        [DataMember(Name = "sourceColumnId", IsRequired = true, EmitDefaultValue = false)]
        public string SourceColumnId { get; set; }

        /// <summary>
        /// Gets or Sets TargetColumnId
        /// </summary>
        [DataMember(Name = "targetColumnId", IsRequired = true, EmitDefaultValue = false)]
        public string TargetColumnId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateDependency {\n");
            sb.Append("  NewId: ").Append(NewId).Append("\n");
            sb.Append("  SourceColumnId: ").Append(SourceColumnId).Append("\n");
            sb.Append("  TargetColumnId: ").Append(TargetColumnId).Append("\n");
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
            return this.Equals(input as UpdateDependency);
        }

        /// <summary>
        /// Returns true if UpdateDependency instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateDependency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateDependency input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NewId == input.NewId ||
                    (this.NewId != null &&
                    this.NewId.Equals(input.NewId))
                ) && 
                (
                    this.SourceColumnId == input.SourceColumnId ||
                    (this.SourceColumnId != null &&
                    this.SourceColumnId.Equals(input.SourceColumnId))
                ) && 
                (
                    this.TargetColumnId == input.TargetColumnId ||
                    (this.TargetColumnId != null &&
                    this.TargetColumnId.Equals(input.TargetColumnId))
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
                if (this.NewId != null)
                {
                    hashCode = (hashCode * 59) + this.NewId.GetHashCode();
                }
                if (this.SourceColumnId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceColumnId.GetHashCode();
                }
                if (this.TargetColumnId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetColumnId.GetHashCode();
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
            // NewId (string) pattern
            Regex regexNewId = new Regex(@"^(?!_)\\w+$", RegexOptions.CultureInvariant);
            if (false == regexNewId.Match(this.NewId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NewId, must match a pattern of " + regexNewId, new [] { "NewId" });
            }

            yield break;
        }
    }

}
