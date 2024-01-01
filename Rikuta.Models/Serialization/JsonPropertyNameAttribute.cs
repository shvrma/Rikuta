using JetBrains.Annotations;

namespace Rikuta.Models.Serialization;

/// <summary>
///     Overrides property name that appears in JSON object.
/// </summary>
/// <param name="name">
///     Property name to be used in JSON.
/// </param>
[PublicAPI]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class JsonPropertyNameAttribute(string name) : Attribute;
