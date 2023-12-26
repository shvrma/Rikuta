using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Rikuta.Helpers;

namespace Rikuta.Models.Interactions;

/// <summary>
/// Represents an application command. 
/// </summary>
/// <param name="ID">Command identifier.</param>
/// <param name="ApplicationID">
/// An application identifier this command belongs to.
/// </param>
/// <param name="GuildID">
/// A guild identifies this command is from; if omitted - the command is global.
/// </param>
/// <param name="CommandName">
/// Name of command.
/// </param>
/// <param name="LocalizedCommandNames">
/// Localization dictionary for <see cref="CommandName"/> field.
/// </param>
/// <param name="Description">
/// Description for <see cref="ApplicationCommandTypes.ChatInput"/> commands.
/// </param>
/// <param name="LocalizedDescriptions">
/// Localization dictionary for <see cref="Description"/> field.
/// </param>
/// <param name="Options">
/// Parameters for the command. Used only in
/// <see cref="ApplicationCommandTypes.ChatInput"/> commands.
/// </param>
/// <param name="DefaultMemberPermissions">
/// Set of permissions for the user to be able to execute the command. 
/// </param>
/// <param name="Version">
/// Auto-incrementing version identifier updated during substantial record changes.
/// </param>
public sealed record ApplicationCommand(
    [property: JsonRequired]
    [property: JsonPropertyName("id")]
    Snowflake ID,

    [property: JsonPropertyName("type")] 
    Optional<ApplicationCommandTypes> CommandType,

    [property: JsonRequired]
    [property: JsonPropertyName("application_id")]
    Snowflake ApplicationID,

    [property: JsonPropertyName("guild_id")]
    Optional<Snowflake> GuildID,

    [property: JsonRequired]
    [property: JsonPropertyName("name")]
    string CommandName,

    [property: JsonPropertyName("name_localizations")]
    Optional<IDictionary<string, string>?> LocalizedCommandNames,

    [property: JsonRequired]
    [property: JsonPropertyName("description")]
    string Description,

    [property: JsonPropertyName("description_localizations")]
    Optional<IDictionary<string, string>?> LocalizedDescriptions,

    [property: JsonPropertyName("options")]
    Optional<ApplicationCommandOption[]> Options,

    [property: JsonRequired]
    [property: JsonPropertyName("default_member_permissions")]
    PermissionsSet? DefaultMemberPermissions,

    [property: JsonPropertyName("dm_permission")]
    Optional<bool> IsDMAllowed,

    [property: JsonPropertyName("nsfw")] 
    Optional<bool> IsNsfw,

    [property: JsonRequired]
    [property: JsonPropertyName("version")]
    Snowflake Version)
{
    /// <summary>
    /// Validates command name according to <see href="https://discord.com/developers/docs/interactions/application-commands#application-command-object-application-command-naming">
    /// Discord's requirements</see>. 
    /// </summary>
    /// <returns>Whether the <see cref="CommandName"/> matches the regex or not.</returns>
    public bool ValidateCommandName()
    {
        return Validation.ChatInputCommandNameAndOptionName().IsMatch(CommandName);
    }
}
