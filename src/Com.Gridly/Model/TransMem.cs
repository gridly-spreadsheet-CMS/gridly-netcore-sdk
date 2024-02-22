/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 4.27.1
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
    /// TransMem
    /// </summary>
    [DataContract(Name = "TransMem")]
    public partial class TransMem : IEquatable<TransMem>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PopulateTranslationStatus
        /// </summary>
        [DataMember(Name = "populateTranslationStatus", EmitDefaultValue = true)]
        public TranslationStatus? PopulateTranslationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransMem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransMem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransMem" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="projectIds">projectIds.</param>
        /// <param name="isDisabled">isDisabled.</param>
        /// <param name="isPausedConsuming">isPausedConsuming.</param>
        /// <param name="populateTranslationStatus">populateTranslationStatus.</param>
        /// <param name="contextLookup">contextLookup.</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="fuzzyMatch">fuzzyMatch.</param>
        public TransMem(string id = default(string), List<long> projectIds = default(List<long>), bool isDisabled = default(bool), bool isPausedConsuming = default(bool), TranslationStatus? populateTranslationStatus = default(TranslationStatus?), bool contextLookup = default(bool), string name = default(string), string description = default(string), bool fuzzyMatch = default(bool))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TransMem and cannot be null");
            }
            this.Name = name;
            this.Id = id;
            this.ProjectIds = projectIds;
            this.IsDisabled = isDisabled;
            this.IsPausedConsuming = isPausedConsuming;
            this.PopulateTranslationStatus = populateTranslationStatus;
            this.ContextLookup = contextLookup;
            this.Description = description;
            this.FuzzyMatch = fuzzyMatch;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ProjectIds
        /// </summary>
        [DataMember(Name = "projectIds", EmitDefaultValue = true)]
        public List<long> ProjectIds { get; set; }

        /// <summary>
        /// Gets or Sets IsDisabled
        /// </summary>
        [DataMember(Name = "isDisabled", EmitDefaultValue = true)]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Gets or Sets IsPausedConsuming
        /// </summary>
        [DataMember(Name = "isPausedConsuming", EmitDefaultValue = true)]
        public bool IsPausedConsuming { get; set; }

        /// <summary>
        /// Gets or Sets ContextLookup
        /// </summary>
        [DataMember(Name = "contextLookup", EmitDefaultValue = true)]
        public bool ContextLookup { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets FuzzyMatch
        /// </summary>
        [DataMember(Name = "fuzzyMatch", EmitDefaultValue = true)]
        public bool FuzzyMatch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransMem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  IsDisabled: ").Append(IsDisabled).Append("\n");
            sb.Append("  IsPausedConsuming: ").Append(IsPausedConsuming).Append("\n");
            sb.Append("  PopulateTranslationStatus: ").Append(PopulateTranslationStatus).Append("\n");
            sb.Append("  ContextLookup: ").Append(ContextLookup).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FuzzyMatch: ").Append(FuzzyMatch).Append("\n");
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
            return this.Equals(input as TransMem);
        }

        /// <summary>
        /// Returns true if TransMem instances are equal
        /// </summary>
        /// <param name="input">Instance of TransMem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransMem input)
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
                    this.ProjectIds == input.ProjectIds ||
                    this.ProjectIds != null &&
                    input.ProjectIds != null &&
                    this.ProjectIds.SequenceEqual(input.ProjectIds)
                ) && 
                (
                    this.IsDisabled == input.IsDisabled ||
                    this.IsDisabled.Equals(input.IsDisabled)
                ) && 
                (
                    this.IsPausedConsuming == input.IsPausedConsuming ||
                    this.IsPausedConsuming.Equals(input.IsPausedConsuming)
                ) && 
                (
                    this.PopulateTranslationStatus == input.PopulateTranslationStatus ||
                    this.PopulateTranslationStatus.Equals(input.PopulateTranslationStatus)
                ) && 
                (
                    this.ContextLookup == input.ContextLookup ||
                    this.ContextLookup.Equals(input.ContextLookup)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FuzzyMatch == input.FuzzyMatch ||
                    this.FuzzyMatch.Equals(input.FuzzyMatch)
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
                if (this.ProjectIds != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectIds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDisabled.GetHashCode();
                hashCode = (hashCode * 59) + this.IsPausedConsuming.GetHashCode();
                hashCode = (hashCode * 59) + this.PopulateTranslationStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.ContextLookup.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FuzzyMatch.GetHashCode();
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
            // Name (string) pattern
            Regex regexName = new Regex(@"\\S", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            yield break;
        }
    }

}
