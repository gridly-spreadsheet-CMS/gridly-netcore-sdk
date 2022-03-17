/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.23.2
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
    /// CreateDependency
    /// </summary>
    [DataContract(Name = "CreateDependency")]
    public partial class CreateDependency : IEquatable<CreateDependency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDependency" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="sourceColumnId">sourceColumnId.</param>
        /// <param name="targetColumnId">targetColumnId.</param>
        public CreateDependency(string id = default(string), string sourceColumnId = default(string), string targetColumnId = default(string))
        {
            this.Id = id;
            this.SourceColumnId = sourceColumnId;
            this.TargetColumnId = targetColumnId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets SourceColumnId
        /// </summary>
        [DataMember(Name = "sourceColumnId", EmitDefaultValue = false)]
        public string SourceColumnId { get; set; }

        /// <summary>
        /// Gets or Sets TargetColumnId
        /// </summary>
        [DataMember(Name = "targetColumnId", EmitDefaultValue = false)]
        public string TargetColumnId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateDependency {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as CreateDependency);
        }

        /// <summary>
        /// Returns true if CreateDependency instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDependency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDependency input)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
            // Id (string) pattern
            Regex regexId = new Regex(@"^(?!_)\\w+$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            yield break;
        }
    }

}
