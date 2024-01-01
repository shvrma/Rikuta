using JetBrains.Annotations;

namespace Rikuta.Models.Interactions.MessageComponents;

[PublicAPI]
public enum TextInputStyles
{
    /// <summary>
    ///     Single-line input.
    /// </summary>
    Short = 1,

    /// <summary>
    ///     Multi-line input.
    /// </summary>
    Paragraph = 2
}
