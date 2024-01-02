using JetBrains.Annotations;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <summary>
/// </summary>
/// <param name="ID">
///     A <see cref="Snowflake" /> ID of a user, role, or channel.
/// </param>
/// <param name="Type">
///     Type of value that <paramref name="ID" /> represents.
///     Either "user", "role", or "channel".
/// </param>
[PublicAPI]
public record SelectDefaultValue(
    [property: JsonPropertyNameOverride("id")]
    Snowflake ID,
    [property: JsonPropertyNameOverride("type")]
    [property: ValueProvider(
            "Rikuta.Models.Interactions.MessageComponents.SelectDefaultValueTypes")]
    string Type);
