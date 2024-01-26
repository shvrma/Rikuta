using JetBrains.Annotations;
using Rikuta.Models.Resources.Emoji;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <summary>
///     An emoji model.
/// </summary>
/// <param name="ID">
///     Emoji ID.
/// </param>
/// <param name="Name">
///     Emoji name (can be null only in reaction emoji objects,
///     when custom emoji data is not available).
/// </param>
/// <param name="IsAnimated">
///     Whether this emoji is animated.
/// </param>
[PublicAPI]
public record PartialEmoji(
    [property: JsonPropertyNameOverride("id")]
    Snowflake? ID,
    [property: JsonPropertyNameOverride("name")]
    string? Name,
    [property: JsonPropertyNameOverride("animated")]
    Optional<bool> IsAnimated) : IPartialEntity<PartialEmoji, Emoji>
{
    public static implicit operator PartialEmoji(Emoji entity)
        => throw new NotImplementedException();

    public static IPartialEntity<PartialEmoji, Emoji> ToPartialEntity(
        Emoji entity)
        => throw new NotImplementedException();
}
