using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Sticker;

/// <summary>
///     A partial sticker object.
/// </summary>
/// <remarks>
///     Handles the smallest amount of data required to render a
///     sticker. 
/// </remarks>
/// <param name="ID">
///     ID of the sticker.
/// </param>
/// <param name="Name">
///     Name of the sticker.
/// </param>
/// <param name="StickerFormatType">
///     Type of sticker format.
/// </param>
[PublicAPI]
public record PartialSticker(
    Snowflake ID,
    string Name,
    StickerFormatTypes StickerFormatType)
        : IPartialEntity<PartialSticker, Sticker>
{
    public static implicit operator PartialSticker(Sticker sticker)
        => new(
                ID: sticker.ID,
                Name: sticker.Name,
                StickerFormatType: sticker.StickerFormatType);

    public static IPartialEntity<PartialSticker, Sticker>
            ToPartialEntity(Sticker entity)
        => throw new NotImplementedException();
}
