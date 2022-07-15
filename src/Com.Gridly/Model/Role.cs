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
    /// Role
    /// </summary>
    [DataContract(Name = "Role")]
    public partial class Role : IEquatable<Role>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="title">title.</param>
        /// <param name="type">type.</param>
        /// <param name="level">level.</param>
        /// <param name="privileges">privileges.</param>
        /// <param name="privilegeIds">privilegeIds.</param>
        /// <param name="isSystemRole">isSystemRole.</param>
        public Role(long id = default(long), string name = default(string), string title = default(string), string type = default(string), string level = default(string), List<Privilege> privileges = default(List<Privilege>), List<long> privilegeIds = default(List<long>), bool isSystemRole = default(bool))
        {
            this.Id = id;
            this.Name = name;
            this.Title = title;
            this.Type = type;
            this.Level = level;
            this.Privileges = privileges;
            this.PrivilegeIds = privilegeIds;
            this.IsSystemRole = isSystemRole;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public string Level { get; set; }

        /// <summary>
        /// Gets or Sets Privileges
        /// </summary>
        [DataMember(Name = "privileges", EmitDefaultValue = false)]
        public List<Privilege> Privileges { get; set; }

        /// <summary>
        /// Gets or Sets PrivilegeIds
        /// </summary>
        [DataMember(Name = "privilegeIds", EmitDefaultValue = false)]
        public List<long> PrivilegeIds { get; set; }

        /// <summary>
        /// Gets or Sets IsSystemRole
        /// </summary>
        [DataMember(Name = "isSystemRole", EmitDefaultValue = true)]
        public bool IsSystemRole { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Role {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Privileges: ").Append(Privileges).Append("\n");
            sb.Append("  PrivilegeIds: ").Append(PrivilegeIds).Append("\n");
            sb.Append("  IsSystemRole: ").Append(IsSystemRole).Append("\n");
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
            return this.Equals(input as Role);
        }

        /// <summary>
        /// Returns true if Role instances are equal
        /// </summary>
        /// <param name="input">Instance of Role to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Role input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.Privileges == input.Privileges ||
                    this.Privileges != null &&
                    input.Privileges != null &&
                    this.Privileges.SequenceEqual(input.Privileges)
                ) && 
                (
                    this.PrivilegeIds == input.PrivilegeIds ||
                    this.PrivilegeIds != null &&
                    input.PrivilegeIds != null &&
                    this.PrivilegeIds.SequenceEqual(input.PrivilegeIds)
                ) && 
                (
                    this.IsSystemRole == input.IsSystemRole ||
                    this.IsSystemRole.Equals(input.IsSystemRole)
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Level != null)
                {
                    hashCode = (hashCode * 59) + this.Level.GetHashCode();
                }
                if (this.Privileges != null)
                {
                    hashCode = (hashCode * 59) + this.Privileges.GetHashCode();
                }
                if (this.PrivilegeIds != null)
                {
                    hashCode = (hashCode * 59) + this.PrivilegeIds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsSystemRole.GetHashCode();
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
