using JetBrains.Annotations;
using Rikuta.Models.Permissions;

namespace Rikuta.Models.Resources.Channel;

/// <summary>
///     Overwrites apply certain permissions to roles or members on a
///     channel level.
/// </summary>
/// <param name="ID">
///     Role or user ID to apply this overwrite to.
/// </param>
/// <param name="Type">
///     <see cref="ChannelPermissionsOverwriteTypes" /> type of
///     overwrite.
/// </param>
/// <param name="AllowedPermissions">
///     Permissions to explicitly allow for an entity.
/// </param>
/// <param name="DeniedPermissions">
///     Permissions to explicitly deny for an entity.
/// </param>
[PublicAPI]
public record ChannelPermissionsOverwrite(
    [property: JsonPropertyNameOverride("id")]
    Snowflake ID,
    [property: JsonPropertyNameOverride("type")]
    ChannelPermissionsOverwriteTypes Type,
    [property: JsonPropertyNameOverride("allow")]
    PermissionsString AllowedPermissions,
    [property: JsonPropertyNameOverride("deny")]
    PermissionsString DeniedPermissions);
