using JetBrains.Annotations;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <summary>
///     The default suggested value for the select menu.
/// </summary>
/// <param name="ID">
///     A <see cref="Snowflake" /> ID of a user, role, or channel.
/// </param>
/// <param name="Type">
///     Type of value that <paramref name="ID" /> property represents.
///     Either "user", "role", or "channel".
/// </param>
/// <seealso cref="SelectDefaultValueTypes" />
[PublicAPI]
public record SelectDefaultValue(
    [property: JsonPropertyNameOverride("id")]
    Snowflake ID,
    [property: JsonPropertyNameOverride("type")]
    [property: ValueProvider(
            "Rikuta.Models.Interactions.MessageComponents.SelectDefaultValueTypes")]
    string Type);
