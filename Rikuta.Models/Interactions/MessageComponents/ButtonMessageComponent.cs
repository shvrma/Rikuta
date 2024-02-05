using JetBrains.Annotations;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <summary>
///     Buttons are interactive components that render in messages.
///     They can be clicked by users, and send an interaction to
///     your app when clicked.
/// </summary>
/// <remarks>
///     Buttons should be placed in an
///     <see cref="ActionRowMessageComponent" />.
///     A <see cref="ActionRowMessageComponent" /> can contain up to 5
///     buttons, but cannot have any select menu components.
/// </remarks>
/// <param name="CustomID">
///     Developer-defined ID for the button. Max. length is 100
///     characters.
///     <remarks>
///         Non-link buttons must have a custom ID specified, and
///         cannot have a <paramref name="Url" />.
///     </remarks>
/// </param>
/// <param name="Style">
///     A button style.
/// </param>
/// <param name="Label">
///     Text that appears on the button. Max. 80 characters long.
/// </param>
/// <param name="Emoji">
///     Emoji that is placed on the button.
/// </param>
/// <param name="Url">
///     URL for <see cref="ButtonStyles.Link" /> buttons.
///     <remarks>
///         Link buttons do not send an interaction to your app
///         when clicked. Link buttons must have a url, and cannot
///         have a <paramref name="CustomID" />.
///     </remarks>
/// </param>
/// <param name="IsDisabled">
///     Whether the button is disabled; default to
///     <see langword="false" />.
/// </param>
[PublicAPI]
public record ButtonMessageComponent(
    string CustomID,
    [property: JsonPropertyNameOverride("style")]
    ButtonStyles Style,
    [property: JsonPropertyNameOverride("label")]
    Optional<string> Label,
    [property: JsonPropertyNameOverride("emoji")]
    Optional<PartialEmoji> Emoji,
    [property: JsonPropertyNameOverride("url")]
    Optional<Uri> Url,
    [property: JsonPropertyNameOverride("disabled")]
    Optional<bool> IsDisabled) : MessageComponentWithID(
        MessageComponentTypes.Button,
        CustomID);
