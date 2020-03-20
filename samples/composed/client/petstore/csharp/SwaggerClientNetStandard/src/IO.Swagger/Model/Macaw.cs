/* 
 * Swagger Petstore
 *
 * This is a sample Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/). 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Macaw
    /// </summary>
    [DataContract]
        public partial class Macaw :  IEquatable<Macaw>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Macaw" /> class.
        /// </summary>
        /// <param name="color">color.</param>
        /// <param name="singer">singer.</param>
        public Macaw(string color = default(string), bool? singer = default(bool?))
        {
            this.Color = color;
            this.Singer = singer;
        }
        
        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets Singer
        /// </summary>
        [DataMember(Name="singer", EmitDefaultValue=false)]
        public bool? Singer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Macaw {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Singer: ").Append(Singer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Macaw);
        }

        /// <summary>
        /// Returns true if Macaw instances are equal
        /// </summary>
        /// <param name="input">Instance of Macaw to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Macaw input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.Singer == input.Singer ||
                    (this.Singer != null &&
                    this.Singer.Equals(input.Singer))
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
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.Singer != null)
                    hashCode = hashCode * 59 + this.Singer.GetHashCode();
                return hashCode;
            }
        }
    }
}
