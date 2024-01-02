using JetBrains.Annotations;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <summary>
///     Text inputs are interactive components that render in
///     modals, prompting the user to type a text.
/// </summary>
/// <param name="CustomID">
///     A <see cref="Snowflake" /> ID for the select menu; max
///     100 characters.
/// </param>
/// <param name="Style"></param>
/// <param name="Label">
///     Label for this component; max. 45 characters.
/// </param>
/// <param name="MinLength">
///     Minimum input length for a text input; min. 0, max. 4000.
/// </param>
/// <param name="MaxLength">
///     Maximum input length for a text input; min. 1, max. 4000.
/// </param>
/// <param name="IsRequired">
///     Whether this component is required to be filled (defaults
///     to <c>true</c>).
/// </param>
/// <param name="Value">
///     Pre-filled value for this component; max. 4000 characters.
/// </param>
/// <param name="Placeholder">
///     Custom placeholder text if the input is empty; max. 100
///     characters.
/// </param>
[PublicAPI]
public record TextInputMessageComponent(
    string CustomID,
    [property: JsonPropertyNameOverride("style")]
    TextInputStyles Style,
    [property: JsonPropertyNameOverride("label")]
    string Label,
    [property: JsonPropertyNameOverride("min_length")]
    Optional<int> MinLength,
    [property: JsonPropertyNameOverride("max_length")]
    Optional<int> MaxLength,
    [property: JsonPropertyNameOverride("required")]
    Optional<bool> IsRequired,
    [property: JsonPropertyNameOverride("value")]
    Optional<string> Value,
    [property: JsonPropertyNameOverride("placeholder")]
    Optional<string> Placeholder) : MessageComponentWithID(
        MessageComponentTypes.TextInput, CustomID);
