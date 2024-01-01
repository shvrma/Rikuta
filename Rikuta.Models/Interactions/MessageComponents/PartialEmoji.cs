using JetBrains.Annotations;
using Rikuta.Models.Resources;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <summary>
///     A partial data about emoji.
/// </summary>
/// <param name="ID">Emoji ID.</param>
/// <param name="Name">
///     Emoji name (can be null only in reaction emoji objects,
///     when custom emoji data is not available).
/// </param>
/// <param name="IsAnimated">
///     Whether this emoji is animated.
/// </param>
[PublicAPI]
public record PartialEmoji(
    Snowflake? ID,
    string? Name,
    Optional<bool> IsAnimated) : Emoji(
    ID,
    Name,
    Optional<Snowflake[]>.Empty,
    Optional<User>.Empty,
    Optional<bool>.Empty,
    Optional<bool>.Empty,
    IsAnimated,
    Optional<bool>.Empty)
{
    private const string PartialDataUnavailableExceptionMessage = "";

    /// <inheritdoc cref="Emoji.AllowedRoles" />
    public new Optional<Snowflake[]> AllowedRoles =>
        throw new NotSupportedException(PartialDataUnavailableExceptionMessage);

    /// <inheritdoc cref="Emoji.User" />
    public new Optional<User> User =>
        throw new NotSupportedException(PartialDataUnavailableExceptionMessage);

    /// <inheritdoc cref="Emoji.RequireColons" />
    public new Optional<bool> RequireColons =>
        throw new NotSupportedException(PartialDataUnavailableExceptionMessage);

    /// <inheritdoc cref="Emoji.IsManaged" />
    public new Optional<bool> IsManaged =>
        throw new NotSupportedException(PartialDataUnavailableExceptionMessage);

    /// <inheritdoc cref="Emoji.IsUsable" />
    public new Optional<bool> IsUsable =>
        throw new NotSupportedException(PartialDataUnavailableExceptionMessage);
}
