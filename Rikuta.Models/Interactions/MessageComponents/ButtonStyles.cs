using JetBrains.Annotations;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <summary>
///     Determines the visual look of the button.
/// </summary>
/// <seealso
///     href="https://discord.com/developers/docs/interactions/message-components#button-object-button-styles">
///     Discord docs
/// </seealso>
[PublicAPI]
public enum ButtonStyles
{
    Primary   = 1,
    Secondary = 2,
    Success   = 3,
    Danger    = 4,

    /// <summary>
    ///     A type with a specific meaning; directs to a particular
    ///     URL defined in <see cref="ButtonMessageComponent.Url" />.
    /// </summary>
    Link = 5
}
