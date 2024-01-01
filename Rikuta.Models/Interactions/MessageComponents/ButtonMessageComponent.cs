using System.ComponentModel.DataAnnotations;
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
///     buttons.
///     A <see cref="ActionRowMessageComponent" /> containing buttons
///     cannot
///     also contain any select menu components.
/// </remarks>
/// <param name="CustomID">
///     Developer-defined ID for the button. Max. length is 100
///     characters.
/// </param>
/// <param name="Style">
///     A button style.
/// </param>
/// <param name="Label">
///     Text that appears on the button. Max. 80 characters.
/// </param>
/// <param name="Emoji">
///     Emoji that is placed on the button.
/// </param>
/// <param name="Url">
///     URL for <see cref="ButtonStyles.Link" /> buttons.
/// </param>
/// <param name="Disabled">
///     Whether the button is disabled.
/// </param>
[PublicAPI]
public record ButtonMessageComponent(
    string CustomID,
    [property: JsonPropertyName("style")]
    ButtonStyles Style,
    [property: JsonPropertyName("label")]
    [property: StringLength(80)]
    Optional<string> Label,
    [property: JsonPropertyName("emoji")]
    Optional<PartialEmoji> Emoji,
    [property: JsonPropertyName("url")]
    Optional<Uri> Url,
    Optional<bool> Disabled) : MessageComponentWithID(MessageComponentTypes.Button, CustomID);
