using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Rikuta.Models.Interactions;

/// <summary>
/// Represent a single choice of value for <see cref="ApplicationCommandOption"/>.
/// </summary>
public sealed record ApplicationCommandOptionChoice(
    [property: JsonRequired]
    [property: JsonPropertyName("name")]
    string Name,

    [property: JsonPropertyName("name_localizations")]
    Optional<IDictionary<string, string>> LocalizedName,

    [property: JsonRequired]
    [property: JsonPropertyName("value")]
    JsonValue Value);
