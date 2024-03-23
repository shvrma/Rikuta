using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

/// <summary>
///     Represents reaction under a message.
/// </summary>
/// <param name="Count">
///     Total number of times this emoji has been used to react
///     (including super reacts).
/// </param>
/// <param name="CountDetails">
///     Contains a breakdown of normal and super reaction counts for the
///     associated emoji.
/// </param>
/// <param name="IsMyReaction">
///     Whether the current user reacted using this emoji.
/// </param>
/// <param name="IsMyBurstReaction">
///     Whether the current user super-reacted using this emoji.
/// </param>
/// <param name="Emoji">
///     Emoji information.
/// </param>
/// <param name="BurstColor">
///     HEX colors used for super reaction.
/// </param>
[PublicAPI]
public record MessageReaction(
    [property: JsonPropertyNameOverride("count")]
    int Count,
    [property: JsonPropertyNameOverride("count_details")]
    MessageReactionCountDetails CountDetails,
    [property: JsonPropertyNameOverride("me")]
    bool IsMyReaction,
    [property: JsonPropertyNameOverride("me_burst")]
    bool IsMyBurstReaction,
    [property: JsonPropertyNameOverride("emoji")]
    Emoji.Emoji Emoji,
    [property: JsonPropertyNameOverride("burst_colors")]
    int[] BurstColor);
