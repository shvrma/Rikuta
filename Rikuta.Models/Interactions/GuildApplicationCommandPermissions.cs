using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rikuta.Models.Interactions;

/// <summary>
/// Returned when fetching the permissions for an app's command(s) in a guild.
/// </summary>
/// <remarks>
/// When the <see cref="ID"/> is the same as <see cref="ApplicationID"/> instead of a command ID,
/// the permissions apply to all commands that do not contain explicit overwrites.
/// </remarks>
/// <param name="ID">ID of the command or the application ID.</param>
/// <param name="Permissions">Permissions for the command in the guild</param>
public record GuildApplicationCommandPermissions(
    [property: JsonRequired]
    [property: JsonPropertyName("id")]
    Snowflake ID,
    
    [property: JsonRequired]
    [property: JsonPropertyName("application_id")]
    Snowflake ApplicationID,
    
    [property: JsonRequired]
    [property: JsonPropertyName("guild_id")]
    Snowflake GuildID,
    
    [property: JsonRequired]
    [property: JsonPropertyName("permissions")]
    ApplicationCommandPermissions[] Permissions);
