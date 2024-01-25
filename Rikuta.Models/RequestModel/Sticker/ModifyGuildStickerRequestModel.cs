namespace Rikuta.Models.RequestModel.Sticker;

/// <summary>
///     Contain parameters used to pass in the
///     <see
///         href="https://discord.com/developers/docs/resources/sticker#modify-guild-sticker">
///         Modify Guild Sticker
///     </see>
///     endpoint.
/// </summary>
/// <param name="Name">
///     Name of the sticker (2-30 characters).
/// </param>
/// <param name="Description">
///     Description of the sticker (2-100 characters).
/// </param>
/// <param name="Tags">
///     Autocomplete/suggestion tags for the sticker (max.
///     200 characters).
/// </param>
public record ModifyGuildStickerRequestModel(
    [property: JsonPropertyNameOverrideAttribute("name")]
    Optional<string> Name,
    [property: JsonPropertyNameOverrideAttribute("description")]
    Optional<string?> Description,
    [property: JsonPropertyNameOverrideAttribute("tags")]
    Optional<string> Tags);
