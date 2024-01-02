using JetBrains.Annotations;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.Interactions.ApplicationCommands;

/// <summary>
///     Application command permissions allow you to enable or
///     disable commands for specific users, roles, or channels
///     within a guild.
/// </summary>
/// <param name="ID">
///     ID of the role, user, or channel this permission applies
///     for.
///     Use the guild ID for <see cref="ID" /> to scope
///     permission to @everyone.
///     To grant permission to all channels in the guild, use
///     the expression <c>guild ID minus 1</c> for <see cref="ID" />.
/// </param>
/// <param name="Permission">
///     Whether to allow or disallow command for the specified
///     consumer.
/// </param>
[PublicAPI]
public record ApplicationCommandPermissions(
    [property: JsonPropertyNameOverride("id")]
    Snowflake ID,
    [property: JsonPropertyNameOverride("type")]
    ApplicationCommandPermissionTypes PermissionType,
    [property: JsonPropertyNameOverride("permission")]
    bool Permission);
