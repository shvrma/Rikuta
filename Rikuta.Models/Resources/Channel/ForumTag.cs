using JetBrains.Annotations;
using Rikuta.Models.Permissions;

namespace Rikuta.Models.Resources.Channel;

/// <summary>
///     An object that represents a tag that is able to be applied to a
///     thread in a <see cref="ChannelTypes.GuildForum" /> or
///     <see cref="ChannelTypes.GuildMedia" /> channel.
/// </summary>
/// <param name="ID">
///     The ID of the tag.
/// </param>
/// <param name="Name">
///     The name of the tag (0-20 characters).
/// </param>
/// <param name="IsModerated">
///     Whether this tag can only be added to or removed from threads by
///     a member with the <see cref="PermissionsFlags.ManageThreads" />
///     permission.
/// </param>
/// <param name="EmojiID">
///     The ID of a guild's custom emoji.
/// </param>
/// <param name="EmojiName">
///     The unicode character of the emoji.
/// </param>
/// <remarks>
///     At most one of <paramref name="EmojiID" /> and
///     <paramref name="EmojiName" /> may be set to a non-null value.
/// </remarks>
[PublicAPI]
public record ForumTag(
    [property: JsonPropertyNameOverride("id")]
    Snowflake ID,
    [property: JsonPropertyNameOverride("name")]
    string Name,
    [property: JsonPropertyNameOverride("moderated")]
    bool IsModerated,
    [property: JsonPropertyNameOverride("emoji_id")]
    Snowflake? EmojiID,
    [property: JsonPropertyNameOverride("emoji_name")]
    string? EmojiName);
