using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Emoji;

/// <summary>
///     An emoji model.
/// </summary>
/// <remarks>
///     Emojis with subscription roles are considered premium
///     emoji, and count toward a separate limit of 25. Emojis
///     cannot be converted between normal and premium after
///     creation.
/// </remarks>
/// <param name="ID">
///     Emoji ID.
/// </param>
/// <param name="Name">
///     Emoji name (can be null only in reaction emoji objects,
///     when custom emoji data is not available).
/// </param>
/// <param name="AllowedRoles">
///     Role ID's, allowed to use this emoji. An emoji cannot
///     have both subscription roles and non-subscription roles.
///     Read about it
///     <see
///         href="https://discord.com/developers/docs/resources/emoji#emoji-object-premium-emoji">
///         there
///     </see>.
/// </param>
/// <param name="User">
///     User, created this emoji.
/// </param>
/// <param name="RequireColons">
///     Whether this emoji must be wrapped in colons.
/// </param>
/// <param name="IsManaged">
///     Whether this emoji is managed by integration.
/// </param>
/// <param name="IsAnimated">
///     Whether this emoji is animated.
/// </param>
/// <param name="IsUsable">
///     Whether this emoji can be used, may be <c>false</c> due
///     to loss of Server Boosts.
/// </param>
[PublicAPI]
public record Emoji(
    [property: JsonPropertyNameOverride("id")]
    Snowflake? ID,
    [property: JsonPropertyNameOverride("name")]
    string? Name,
    [property: JsonPropertyNameOverride("roles")]
    Optional<Snowflake[]> AllowedRoles,
    [property: JsonPropertyNameOverride("user")]
    Optional<User> User,
    [property: JsonPropertyNameOverride("require_colons")]
    Optional<bool> RequireColons,
    [property: JsonPropertyNameOverride("managed")]
    Optional<bool> IsManaged,
    [property: JsonPropertyNameOverride("animated")]
    Optional<bool> IsAnimated,
    [property: JsonPropertyNameOverride("available")]
    Optional<bool> IsUsable);
