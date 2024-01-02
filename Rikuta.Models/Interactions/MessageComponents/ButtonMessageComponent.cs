using JetBrains.Annotations;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <summary>
///     Buttons are interactive components that render in messages.
///     They can be clicked by users, and send an interaction to
///     your app when clicked.
/// </summary>
/// <remarks>
///     Buttons must be sent inside a
///     <see cref="ActionRowMessageComponent" />.
///     A <see cref="ActionRowMessageComponent" /> can contain up to 5
///     buttons. A <see cref="ActionRowMessageComponent" /> containing
///     buttons cannot also contain any select menu components.
/// </remarks>
/// <param name="CustomID">
///     Developer-defined ID for the button. Max. length is 100
///     characters.
/// </param>
/// <param name="Style">
///     A button style.
/// </param>
/// <param name="Label">
///     Text that appears on the button.
///     <para>Max. 80 characters long.</para>
/// </param>
/// <param name="Emoji">
///     Emoji that is placed on the button.
/// </param>
/// <param name="Url">
///     URL for <see cref="ButtonStyles.Link" /> buttons.
/// </param>
/// <param name="Disabled">
///     Whether the button is disabled; default to <c>false</c>.
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
    Optional<bool> Disabled) : MessageComponentWithID(
        MessageComponentTypes.Button, CustomID);
