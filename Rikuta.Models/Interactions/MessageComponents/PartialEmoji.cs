using JetBrains.Annotations;
using Rikuta.Models.Resources;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <inheritdoc cref="Emoji" />
/// <remarks>
///     Only <paramref name="Name" />, <paramref name="ID" /> and
///     <paramref name="IsAnimated" /> are available.
/// </remarks>
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
        Optional<bool>.Empty), IPartialEntity
{
    /// <inheritdoc cref="Emoji.AllowedRoles" />
    public static new Optional<Snowflake[]> AllowedRoles =>
            throw IPartialEntity.PartialDataUnavailableException;

    /// <inheritdoc cref="Emoji.User" />
    public static new Optional<User> User =>
            throw IPartialEntity.PartialDataUnavailableException;

    /// <inheritdoc cref="Emoji.RequireColons" />
    public static new Optional<bool> RequireColons =>
            throw IPartialEntity.PartialDataUnavailableException;

    /// <inheritdoc cref="Emoji.IsManaged" />
    public static new Optional<bool> IsManaged =>
            throw IPartialEntity.PartialDataUnavailableException;

    /// <inheritdoc cref="Emoji.IsUsable" />
    public static new Optional<bool> IsUsable =>
            throw IPartialEntity.PartialDataUnavailableException;
}
