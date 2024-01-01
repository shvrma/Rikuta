using JetBrains.Annotations;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.Interactions.ApplicationCommands;

/// <summary>
///     Returned when fetching the permissions for an app's
///     command(s) in a guild.
/// </summary>
/// <remarks>
///     When the <see cref="ID" /> is the same as
///     <see cref="ApplicationID" /> instead of a command ID,
///     the permissions apply to all commands that do not contain
///     explicit overwrites.
/// </remarks>
/// <param name="ID">
///     ID of the command or the application ID.
/// </param>
/// <param name="Permissions">
///     Permissions for the command in the guild.
/// </param>
[PublicAPI]
public record GuildApplicationCommandPermissions(
    [property: JsonPropertyName("id")]
    Snowflake ID,
    [property: JsonPropertyName("application_id")]
    Snowflake ApplicationID,
    [property: JsonPropertyName("guild_id")]
    Snowflake GuildID,
    [property: JsonPropertyName("permissions")]
    ApplicationCommandPermissions[] Permissions)
{
    /// <summary>
    ///     Determines whether this permission applies to all
    ///     commands in the guild until some of them have an explicit
    ///     overwrite.
    /// </summary>
    public bool IsDefaultPermission()
    {
        return ID == ApplicationID;
    }
}
