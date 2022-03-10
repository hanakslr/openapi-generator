// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// EquilateralTriangle
    /// </summary>
    public partial class EquilateralTriangle : IEquatable<EquilateralTriangle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EquilateralTriangle" /> class.
        /// </summary>
        /// <param name="shapeInterface">shapeInterface</param>
        /// <param name="triangleInterface">triangleInterface</param>
        public EquilateralTriangle(ShapeInterface shapeInterface, TriangleInterface triangleInterface)
        {
            ShapeInterface = shapeInterface;
            TriangleInterface = triangleInterface;
        }

        /// <summary>
        /// Gets or Sets EquilateralTriangle
        /// </summary>
        public ShapeInterface ShapeInterface { get; set; }

        /// <summary>
        /// Gets or Sets EquilateralTriangle
        /// </summary>
        public TriangleInterface TriangleInterface { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; set; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EquilateralTriangle {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as EquilateralTriangle).AreEqual;
        }

        /// <summary>
        /// Returns true if EquilateralTriangle instances are equal
        /// </summary>
        /// <param name="input">Instance of EquilateralTriangle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EquilateralTriangle input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
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

    /// <summary>
    /// A Json converter for type EquilateralTriangle
    /// </summary>
    public class EquilateralTriangleJsonConverter : JsonConverter<EquilateralTriangle>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(EquilateralTriangle).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EquilateralTriangle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            Utf8JsonReader shapeInterfaceReader = reader;
            Client.ClientUtils.TryDeserialize<ShapeInterface>(ref shapeInterfaceReader, options, out ShapeInterface shapeInterface);
            Utf8JsonReader triangleInterfaceReader = reader;
            Client.ClientUtils.TryDeserialize<TriangleInterface>(ref triangleInterfaceReader, options, out TriangleInterface triangleInterface);

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                    }
                }
            }

            return new EquilateralTriangle(shapeInterface, triangleInterface);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="equilateralTriangle"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EquilateralTriangle equilateralTriangle, JsonSerializerOptions options) => throw new NotImplementedException();
    }
}
