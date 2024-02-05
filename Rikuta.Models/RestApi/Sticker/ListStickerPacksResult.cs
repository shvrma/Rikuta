using JetBrains.Annotations;
using Rikuta.Models.Resources.Sticker;

namespace Rikuta.Models.RestApi.Sticker;

/// <summary>
///     Contain parameters used to retrieve from
///     <see
///         href="https://discord.com/developers/docs/resources/sticker#list-sticker-packs">
///         List Sticker Packs
///     </see>
///     endpoint.
/// </summary>
[PublicAPI]
public record ListStickerPacksResult(
    [property: JsonPropertyNameOverride("sticker_packs")]
    StickerPack[] StickerPacks);
