/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 4.15.1
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
    /// CreateView
    /// </summary>
    [DataContract(Name = "CreateView")]
    public partial class CreateView : IEquatable<CreateView>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateView" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="columns">columns.</param>
        /// <param name="gridId">gridId.</param>
        public CreateView(string name = default(string), List<AddViewColumn> columns = default(List<AddViewColumn>), string gridId = default(string))
        {
            this.Name = name;
            this.Columns = columns;
            this.GridId = gridId;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [DataMember(Name = "columns", EmitDefaultValue = true)]
        public List<AddViewColumn> Columns { get; set; }

        /// <summary>
        /// Gets or Sets GridId
        /// </summary>
        [DataMember(Name = "gridId", EmitDefaultValue = true)]
        public string GridId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateView {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  GridId: ").Append(GridId).Append("\n");
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
            return this.Equals(input as CreateView);
        }

        /// <summary>
        /// Returns true if CreateView instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateView input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Columns != null)
                {
                    hashCode = (hashCode * 59) + this.Columns.GetHashCode();
                }
                if (this.GridId != null)
                {
                    hashCode = (hashCode * 59) + this.GridId.GetHashCode();
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
