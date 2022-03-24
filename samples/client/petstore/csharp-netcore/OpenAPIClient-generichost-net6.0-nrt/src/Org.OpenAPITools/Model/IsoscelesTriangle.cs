// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

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
    /// IsoscelesTriangle
    /// </summary>
    public partial class IsoscelesTriangle : IEquatable<IsoscelesTriangle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsoscelesTriangle" /> class.
        /// </summary>
        /// <param name="shapeInterface">shapeInterface</param>
        /// <param name="triangleInterface">triangleInterface</param>
        public IsoscelesTriangle(ShapeInterface? shapeInterface, TriangleInterface? triangleInterface)
        {
            ShapeInterface = shapeInterface;
            TriangleInterface = triangleInterface;
        }

        /// <summary>
        /// Gets or Sets IsoscelesTriangle
        /// </summary>
        public ShapeInterface? ShapeInterface { get; set; }

        /// <summary>
        /// Gets or Sets IsoscelesTriangle
        /// </summary>
        public TriangleInterface? TriangleInterface { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IsoscelesTriangle {\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object? input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as IsoscelesTriangle).AreEqual;
        }

        /// <summary>
        /// Returns true if IsoscelesTriangle instances are equal
        /// </summary>
        /// <param name="input">Instance of IsoscelesTriangle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsoscelesTriangle? input)
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
    /// A Json converter for type IsoscelesTriangle
    /// </summary>
    public class IsoscelesTriangleJsonConverter : JsonConverter<IsoscelesTriangle>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(IsoscelesTriangle).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override IsoscelesTriangle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            Utf8JsonReader shapeInterfaceReader = reader;
            Client.ClientUtils.TryDeserialize<ShapeInterface>(ref shapeInterfaceReader, options, out ShapeInterface? shapeInterface);
            Utf8JsonReader triangleInterfaceReader = reader;
            Client.ClientUtils.TryDeserialize<TriangleInterface>(ref triangleInterfaceReader, options, out TriangleInterface? triangleInterface);

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string? propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                    }
                }
            }

            return new IsoscelesTriangle(shapeInterface, triangleInterface);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="isoscelesTriangle"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, IsoscelesTriangle isoscelesTriangle, JsonSerializerOptions options) => throw new NotImplementedException();
    }
}
