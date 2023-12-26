using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rikuta.Models.Interactions;

/// <summary>
/// Application command permissions allow you to enable or
/// disable commands for specific users, roles, or channels within a guild.
/// </summary>
/// <param name="ID">
/// ID of the role, user, or channel. It can also be a permission constant.
/// Use a guild ID for <see cref="ID"/> to scope the permission to as @everyone.
/// Use a guild ID minus 1 for <see cref="ID"/> to scope the permission to all channels in the guild.
/// </param>
/// <param name="Permission">Whether to allow or disallow command for the specified consumer.</param>
public record ApplicationCommandPermissions(
    [property: JsonRequired]
    [property: JsonPropertyName("id")]
    Snowflake ID,

    [property: JsonRequired]
    [property: JsonPropertyName("type")]
    ApplicationCommandPermissionTypes PermissionType,

    [property: JsonRequired]
    [property: JsonPropertyName("permission")]
    bool Permission);
