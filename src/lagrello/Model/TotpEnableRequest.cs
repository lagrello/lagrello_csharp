/*
 * Lagrello API
 *
 * API specification for Lagrello, a simple to use authentication service
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@lagrello.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = lagrello.Client.OpenAPIDateConverter;

namespace lagrello.Model
{
    /// <summary>
    /// request to enable google authenticator method for user
    /// </summary>
    [DataContract]
    public partial class TotpEnableRequest :  IEquatable<TotpEnableRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TotpEnableRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TotpEnableRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TotpEnableRequest" /> class.
        /// </summary>
        /// <param name="enable">enable (required).</param>
        public TotpEnableRequest(bool enable = default(bool))
        {
            // to ensure "enable" is required (not null)
            if (enable == null)
            {
                throw new InvalidDataException("enable is a required property for TotpEnableRequest and cannot be null");
            }
            else
            {
                this.Enable = enable;
            }

        }

        /// <summary>
        /// Gets or Sets Enable
        /// </summary>
        [DataMember(Name="enable", EmitDefaultValue=true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TotpEnableRequest {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
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
            return this.Equals(input as TotpEnableRequest);
        }

        /// <summary>
        /// Returns true if TotpEnableRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TotpEnableRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TotpEnableRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
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
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
