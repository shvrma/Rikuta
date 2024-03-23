using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

/// <summary>
///     An object that specifies the emoji to use as the default way to
///     react to a forum post. Exactly one of the fields must be set.
/// </summary>
/// <param name="EmojiID">
///     The ID of a guild's custom emoji.
/// </param>
/// <param name="EmojiName">
///     The unicode character of the emoji.
/// </param>
[PublicAPI]
public record ChannelDefaultReaction(
    [property: JsonPropertyNameOverride("emoji_id")]
    Snowflake? EmojiID,
    [property: JsonPropertyNameOverride("emoji_name")]
    string? EmojiName);
