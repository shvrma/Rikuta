using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rikuta.Models.Interactions;

/// <summary>
/// Application command permissions allow you to enable or
/// disable commands for specific users, roles, or channels within a guild.
/// </summary>
/// <param name="ID">
/// ID of the role, user, or channel this permission applies for.
/// Use the guild ID for <see cref="ID"/> value to scope permission to @everyone.
/// To grant permission to all channels in the guild, use the expression
/// <c>guild ID minus 1</c> for <see cref="ID"/> value.
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
