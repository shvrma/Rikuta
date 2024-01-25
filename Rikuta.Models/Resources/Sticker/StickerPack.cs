using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Sticker;

/// <summary>
///     Represents a pack of <b>standard</b> stickers.
/// </summary>
/// <param name="ID">
///     ID of the sticker pack.
/// </param>
/// <param name="Stickers">
///     The stickers in the pack.
/// </param>
/// <param name="Name">
///     Name of the sticker pack.
/// </param>
/// <param name="SkuID">
///     ID of the pack's SKU.
/// </param>
/// <param name="CoverStickerID">
///     ID of a sticker in the pack which is shown as the pack's icon.
/// </param>
/// <param name="Description">
///     Description of the sticker pack.
/// </param>
/// <param name="BannerAssetID">
///     ID of the sticker pack's banner image.
/// </param>
[PublicAPI]
public record StickerPack(
    [property: JsonPropertyNameOverride("id")]
    Snowflake ID,
    [property: JsonPropertyNameOverride("stickers")]
    Sticker[] Stickers,
    [property: JsonPropertyNameOverride("name")]
    string Name,
    [property: JsonPropertyNameOverride("sku_id")]
    Snowflake SkuID,
    [property: JsonPropertyNameOverride("cover_sticker_id")]
    Optional<Snowflake> CoverStickerID,
    [property: JsonPropertyNameOverride("description")]
    string Description,
    [property: JsonPropertyNameOverride("banner_asset_id")]
    Optional<Snowflake> BannerAssetID);
