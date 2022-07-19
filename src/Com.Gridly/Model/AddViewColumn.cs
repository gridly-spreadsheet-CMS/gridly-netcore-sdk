/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.31.0
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
    /// AddViewColumn
    /// </summary>
    [DataContract(Name = "AddViewColumn")]
    public partial class AddViewColumn : IEquatable<AddViewColumn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddViewColumn" /> class.
        /// </summary>
        /// <param name="editable">editable.</param>
        /// <param name="id">id.</param>
        public AddViewColumn(bool editable = default(bool), string id = default(string))
        {
            this.Editable = editable;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Editable
        /// </summary>
        [DataMember(Name = "editable", EmitDefaultValue = true)]
        public bool Editable { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddViewColumn {\n");
            sb.Append("  Editable: ").Append(Editable).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as AddViewColumn);
        }

        /// <summary>
        /// Returns true if AddViewColumn instances are equal
        /// </summary>
        /// <param name="input">Instance of AddViewColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddViewColumn input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Editable == input.Editable ||
                    this.Editable.Equals(input.Editable)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                hashCode = (hashCode * 59) + this.Editable.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
