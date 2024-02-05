using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Sticker;

/// <summary>
///     Represents a sticker that can be sent in messages.
/// </summary>
/// <param name="ID">
///     ID of the sticker
/// </param>
/// <param name="PackID">
///     For standard stickers, ID of the pack the sticker is from.
/// </param>
/// <param name="Name">
///     Name of the sticker.
/// </param>
/// <param name="Description">
///     Description of the sticker.
/// </param>
/// <param name="Tags">
///     Autocomplete/suggestion tags for the sticker (max. 200
///     characters in length).
///     <remarks>
///         A comma-separated list of keywords is the format used in
///         this field by standard stickers, but this is just a
///         convention. Incidentally, the client will always use a
///         name generated from an emoji as the value of this field
///         when creating or modifying a guild sticker.
///     </remarks>
/// </param>
/// <param name="StickerType">
///     Type of sticker.
/// </param>
/// <param name="StickerFormatType">
///     Type of sticker format.
/// </param>
/// <param name="IsAvailable">
///     Whether this guild sticker can be used, may be false due to
///     loss of Server Boosts.
/// </param>
/// <param name="GuildID">
///     ID of the guild that owns this sticker.
/// </param>
/// <param name="User">
///     The user that uploaded the guild sticker.
/// </param>
/// <param name="SortValue">
///     The standard sticker's sort order within its pack.
/// </param>
[PublicAPI]
public record Sticker(
    [property: JsonPropertyNameOverride("id")]
    Snowflake ID,
    [property: JsonPropertyNameOverride("pack_id")]
    Optional<Snowflake> PackID,
    [property: JsonPropertyNameOverride("name")]
    string Name,
    [property: JsonPropertyNameOverride("description")]
    string? Description,
    [property: JsonPropertyNameOverride("tags")]
    string Tags,
    [property: JsonPropertyNameOverride("type")]
    StickerTypes StickerType,
    [property: JsonPropertyNameOverride("format_type")]
    StickerFormatTypes StickerFormatType,
    [property: JsonPropertyNameOverride("available")]
    Optional<bool> IsAvailable,
    [property: JsonPropertyNameOverride("guild_id")]
    Optional<Snowflake> GuildID,
    [property: JsonPropertyNameOverride("user")]
    Optional<User.User> User,
    [property: JsonPropertyNameOverride("sort_value")]
    Optional<int> SortValue);
