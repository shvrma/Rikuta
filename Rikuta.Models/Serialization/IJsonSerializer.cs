using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rikuta.Models.Serialization;

/// <summary>
/// An interface for JSON serializer for the models in this project.
/// </summary>
/// <remarks>
/// Your interface implementation should rely on the <see cref="JsonPropertyNameAttribute"/>
/// and <see cref="JsonSerializableAttribute"/> attributes for serialization/deserialization.
/// </remarks>
public interface IJsonSerializer
{
    /// <summary>
    /// Initializes given instance of <see cref="IJsonSerializer"/>.
    /// </summary>
    void Initialize();

    /// <summary>
    /// Serializes the given object into UTF-8 encoded JSON. 
    /// </summary>
    /// <typeparam name="T">Object type to serialize from.</typeparam>
    /// <param name="value">Object to serialize from.</param>
    ReadOnlyMemory<char> Serialize<T>(T value);

    /// <summary>
    /// Deserializes given UTF-8 JSON string to an appropriate object. 
    /// </summary>
    /// <typeparam name="T">Type to deserialize to.</typeparam>
    /// <param name="input">Object to deserialize to.</param>    
    T Deserialize<T>(ReadOnlyMemory<char> input);
}
