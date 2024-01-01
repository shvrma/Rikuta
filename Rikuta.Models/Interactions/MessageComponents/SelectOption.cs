using JetBrains.Annotations;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <summary>
///     Options that appear in the dropdown list for
///     <see cref="MessageComponentTypes.StringSelect" /> menus.
/// </summary>
/// <param name="Label">
///     User-facing name of the option; max. 100 characters.
/// </param>
/// <param name="Value">
///     Dev-defined value of the option; max. 100 characters.
/// </param>
/// <param name="Description">
///     Additional description of the option; max 100 characters.
/// </param>
/// <param name="Emoji">
///     Emoji to display with an option.
/// </param>
/// <param name="IsDefault">
///     Will show this option as selected by default.
/// </param>
[PublicAPI]
public record SelectOption(
    [property: JsonPropertyName("label")]
    string Label,
    [property: JsonPropertyName("value")]
    string Value,
    [property: JsonPropertyName("description")]
    Optional<string> Description,
    [property: JsonPropertyName("emoji")]
    Optional<PartialEmoji> Emoji,
    [property: JsonPropertyName("default")]
    Optional<bool> IsDefault);
