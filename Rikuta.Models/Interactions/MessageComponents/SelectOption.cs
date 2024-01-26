using JetBrains.Annotations;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <summary>
///     Options that appear in the dropdown list for
///     <see cref="MessageComponentTypes.StringSelect" /> menus.
/// </summary>
/// <param name="Label">
///     User-facing name of the option, max. 100 characters in length.
/// </param>
/// <param name="Value">
///     Value for the option, max. 100 characters in length.
/// </param>
/// <param name="Description">
///     Additional description of the option, max. 100 characters
///     in length.
/// </param>
/// <param name="Emoji">
///     Emoji to display with an option.
/// </param>
/// <param name="IsDefault">
///     Whether show this option as selected by default.
/// </param>
[PublicAPI]
public record SelectOption(
    [property: JsonPropertyNameOverride("label")]
    string Label,
    [property: JsonPropertyNameOverride("value")]
    string Value,
    [property: JsonPropertyNameOverride("description")]
    Optional<string> Description,
    [property: JsonPropertyNameOverride("emoji")]
    Optional<PartialEmoji> Emoji,
    [property: JsonPropertyNameOverride("default")]
    Optional<bool> IsDefault);
