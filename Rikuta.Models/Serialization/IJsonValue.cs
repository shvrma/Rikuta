using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace Rikuta.Models.Serialization;

/// <summary>
///     Stores arbitrary JSON value.
/// </summary>
/// <remarks>
///     This type represents a value within a JSON object. It can be a
///     JSON object or a top-level node, but it should not store the key
///     under which this value was registered.
/// </remarks>
[PublicAPI]
public interface IJsonValue
{
    /// <summary>
    ///     Try to deserialize the underlying JSON value to a concrete type.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="T">Type, to deserialize to.</typeparam>
    /// <returns>
    ///     Whether deserialization was successful or failed.
    /// </returns>
    bool TryDeserialize<T>([NotNullWhen(true)] out T? value);

    /// <summary>
    ///     Deserialize the underlying JSON value to a concrete type.
    /// </summary>
    /// <typeparam name="T">Type, to deserialize to.</typeparam>
    /// <returns>
    ///     Deserialized object if success; <see langword="null" />
    ///     otherwise.
    /// </returns>
    T? Deserialize<T>();
}
