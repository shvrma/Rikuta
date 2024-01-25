using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Sticker;

[PublicAPI]
public enum StickerTypes
{
    Standard = 1,

    /// <summary>
    ///     A sticker uploaded to a guild for the guild's members.
    /// </summary>
    Guild = 2
}
