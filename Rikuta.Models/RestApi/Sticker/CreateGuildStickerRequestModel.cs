using Rikuta.Models.Resources.Sticker;

namespace Rikuta.Models.RequestModel.Sticker;

/// <summary>
///     Contain parameters used to pass in the
///     <see
///         href="https://discord.com/developers/docs/resources/sticker#create-guild-sticker">
///         Create Guild Sticker
///     </see>
///     endpoint.
/// </summary>
/// <param name="StickerContent">
///     The sticker file to upload, must be a PNG, APNG, GIF, or
///     Lottie JSON file, max. 512 KiB.
/// </param>
/// <seealso cref="Sticker" />
public record CreateGuildStickerRequestModel(
    [property: JsonPropertyNameOverride("name")]
    string Name,
    [property: JsonPropertyNameOverride("description")]
    string Description,
    [property: JsonPropertyNameOverride("tags")]
    string Tags,
    [property: JsonPropertyNameOverride("file")]
    Stream StickerContent);
