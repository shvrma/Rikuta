namespace Rikuta.Models.Serialization;

/// <summary>
/// Stores arbitrary JSON value.
/// </summary>
public interface IJsonValue
{
    /// <summary>
    /// Deserialize current JSON value to a concrete type.
    /// </summary>
    /// <typeparam name="T">Type, to deserialize to.</typeparam>
    T Deserialize<T>();
}
