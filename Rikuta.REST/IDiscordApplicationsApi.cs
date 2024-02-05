using System.Net;
using Refit;
using Rikuta.Models;
using Rikuta.Models.Interactions.ApplicationCommands;
using Rikuta.Models.RestApi.ApplicationCommands;

namespace Rikuta.REST;

public interface IDiscordApplicationsApi
{
    #region Application commands

    /// <summary>
    ///     Fetch all the global commands for your application.
    /// </summary>
    /// <remarks>
    ///     If the application locale is set, the response will include
    ///     properties <see cref="ApplicationCommand.LocalizedCommandName" />
    ///     and
    ///     <see cref="ApplicationCommand.LocalizedDescription" /> set.
    /// </remarks>
    /// <param name="applicationID">
    ///     A <see cref="Snowflake" /> ID of application.
    /// </param>
    /// <param name="includeLocalization">
    ///     Whether to include full localization dictionaries
    ///     (<see cref="ApplicationCommand.LocalizedCommandNames" /> and
    ///     <see cref="ApplicationCommand.LocalizedDescriptions" />) in
    ///     the returned objects. Default <c>false</c>.
    /// </param>
    [Get(
            "/applications/{applicationID.Value}/commands?with_localizations={includeLocalization}")]
    Task<ApplicationCommand[]> GetGlobalApplicationCommandsAsync(
        Snowflake applicationID, bool? includeLocalization = false);

    [Post("/applications/{applicationID.Value}/commands")]
    internal Task<ApiResponse<ApplicationCommand>>
            CreateGlobalApplicationCommandInternalAsync(
                Snowflake applicationID,
                [Body]
                CreateGlobalApplicationCommandRequestModel command);

    /// <summary>
    ///     Create a new global command. Returns <c>false</c> as the value
    ///     of a first parameter if a command with the same name does not
    ///     already exist, or a <c>true</c> for the first parameter if it
    ///     does (in which case the previous command will be overwritten).
    /// </summary>
    /// <remarks>
    ///     Creating a command with the same name as an existing command
    ///     for your application will overwrite the old command.
    /// </remarks>
    /// <param name="applicationID">
    ///     A <see cref="Snowflake" /> ID of application.
    /// </param>
    /// <param name="command">
    ///     Command to add or overwrite.
    /// </param>
    /// <returns>
    ///     A <see cref="Tuple" /> with a parameter specifying whether the
    ///     command was overwritten or added, and the second parameter is
    ///     the command itself.
    /// </returns>
    async Task<(bool WasCommandOverwritten, ApplicationCommand command
        )> CreateGlobalApplicationCommandAsync(
        Snowflake applicationID,
        CreateGlobalApplicationCommandRequestModel command)
    {
        ApiResponse<ApplicationCommand> response =
                await CreateGlobalApplicationCommandInternalAsync(
                        applicationID,
                        command);

        // ReSharper disable once SwitchExpressionHandlesSomeKnownEnumValuesWithExceptionInDefault
        return response.StatusCode switch
        {
                HttpStatusCode.OK => (WasCommandOverwritten: true,
                    response.Content!),
                HttpStatusCode.Created => (
                    WasCommandOverwritten: false, response.Content!),
                _ => throw new Exception(
                        $"Unexpected status code: {response.StatusCode}.",
                        response.Error)
        };
    }

    /// <summary>
    ///     Fetch a global command for your application.
    /// </summary>
    /// <param name="applicationID">
    ///     A <see cref="Snowflake" /> ID of application.
    /// </param>
    /// <param name="commandID">
    ///     A <see cref="Snowflake" /> command ID.
    /// </param>
    [Get(
            "/applications/{applicationID.Value}/commands/{commandID.Value}")]
    Task<ApplicationCommand> GetGlobalApplicationCommandAsync(
        Snowflake applicationID, Snowflake commandID);

    /// <summary>
    ///     Edit a global command.
    /// </summary>
    /// <remarks>
    ///     All fields are optional, but any fields provided will
    ///     entirely overwrite the existing values of those fields.
    /// </remarks>
    /// <param name="applicationID">
    ///     A <see cref="Snowflake" /> ID of application.
    /// </param>
    /// <param name="commandID">
    ///     A <see cref="Snowflake" /> command ID.
    /// </param>
    /// <param name="command">
    ///     New command state. Set only those properties You would
    ///     like to change.
    /// </param>
    /// <returns>
    ///     Returns an edited <see cref="ApplicationCommand" /> object.
    /// </returns>
    [Patch(
            "/applications/{applicationID.Value}/commands/{commandID.Value}")]
    Task<ApplicationCommand> EditGlobalApplicationCommandAsync(
        Snowflake applicationID, Snowflake commandID,
        [Body] EditGlobalApplicationCommandRequestModel command);

    /// <summary>
    ///     Deletes a global command.
    /// </summary>
    /// <param name="applicationID">
    ///     A <see cref="Snowflake" /> ID of application.
    /// </param>
    /// <param name="commandID">
    ///     A <see cref="Snowflake" /> command ID.
    /// </param>
    [Delete(
            "/applications/{applicationID.Value}/commands/{commandID.Value}")]
    Task DeleteGlobalApplicationCommandAsync(
        Snowflake applicationID, Snowflake commandID);

    /// <summary>
    ///     Takes a list of application commands, overwriting the
    ///     existing global command list for this application.
    /// </summary>
    /// <remarks>
    ///     This will overwrite all types of application commands:
    ///     slash commands, user commands, and message commands.
    ///     Commands that do not already exist will count toward
    ///     daily application command create limits.
    /// </remarks>
    /// <param name="applicationID">
    ///     A <see cref="Snowflake" /> ID of application.
    /// </param>
    /// <param name="commands">
    ///     Commands to overwrite.
    /// </param>
    /// <returns>
    ///     An array of newly overwritten application commands.
    /// </returns>
    [Put("/applications/{applicationID.Value}/commands")]
    Task<ApplicationCommand[]>
            BulkOverwriteGlobalApplicationCommandsAsync(
                Snowflake applicationID,
                [Body] IEnumerable<ApplicationCommand> commands);

    /// <summary>
    ///     Fetch all the guild commands for your application for a
    ///     specific guild.
    /// </summary>
    /// <remarks>
    ///     If the application locale is set, the response will include
    ///     properties
    ///     <see cref="ApplicationCommand.LocalizedCommandName" /> and
    ///     <see cref="ApplicationCommand.LocalizedDescription" /> set.
    /// </remarks>
    /// <param name="applicationID">
    ///     A <see cref="Snowflake" /> ID of application.
    /// </param>
    /// <param name="guildID">
    ///     A <see cref="Snowflake" /> ID of the guild to get commands from.
    /// </param>
    /// <param name="includeLocalization">
    ///     Whether to include full localization dictionaries
    ///     (<see cref="ApplicationCommand.LocalizedCommandNames" />
    ///     and <see cref="ApplicationCommand.LocalizedDescriptions" />)
    ///     in the returned objects. Default <c>false</c>.
    /// </param>
    [Get(
            "/applications/{applicationID.Value}/guilds/{guildID.Value}/commands?with_localizations={includeLocalization}")]
    Task<ApplicationCommand[]> GetGuildApplicationCommandsAsync(
        Snowflake applicationID, Snowflake guildID,
        bool? includeLocalization = false);

    [Post(
            "/applications/{applicationID.Value}/guilds/{guildID.Value}/commands")]
    internal Task<ApiResponse<ApplicationCommand>>
            CreateGuildApplicationCommandInternalAsync(
                Snowflake applicationID, Snowflake guildID,
                CreateGuildApplicationCommandRequestModel command);

    /// <summary>
    ///     Create a new guild command.
    /// </summary>
    /// <remarks>
    ///     New guild commands will be available in the guild immediately.
    ///     Creating a command with the same name as an existing
    ///     command for your application will overwrite the old command.
    /// </remarks>
    /// <param name="applicationID">
    ///     A <see cref="Snowflake" /> ID of application.
    /// </param>
    /// <param name="guildID">
    ///     A <see cref="Snowflake" /> ID of the guild to get commands from.
    /// </param>
    /// <param name="command">
    ///     Command to be created.
    /// </param>
    /// <returns>
    ///     A <see cref="Tuple" /> with a parameter specifying whether the
    ///     command was
    ///     overwritten or added, and the second parameter is the command
    ///     itself.
    /// </returns>
    async Task<(bool WasCommandOverwritten, ApplicationCommand command
        )> CreateGuildApplicationCommandAsync(
        Snowflake applicationID, Snowflake guildID,
        CreateGuildApplicationCommandRequestModel command)
    {
        ApiResponse<ApplicationCommand> response =
                await CreateGuildApplicationCommandInternalAsync(
                        applicationID,
                        guildID,
                        command);

        // ReSharper disable once SwitchExpressionHandlesSomeKnownEnumValuesWithExceptionInDefault
        return response.StatusCode switch
        {
                HttpStatusCode.OK => (WasCommandOverwritten: true,
                    response.Content!),
                HttpStatusCode.Created => (
                    WasCommandOverwritten: false, response.Content!),
                _ => throw new Exception(
                        $"Unexpected status code: {response.StatusCode}.",
                        response.Error)
        };
    }

    /// <summary>
    ///     Fetch a guild command for your application.
    /// </summary>
    /// <param name="applicationID">
    ///     A <see cref="Snowflake" /> ID of application.
    /// </param>
    /// <param name="guildID">
    ///     A <see cref="Snowflake" /> ID of the guild to get commands from.
    /// </param>
    /// <param name="commandID">
    ///     A <see cref="Snowflake" /> command ID.
    /// </param>
    [Get(
            "/applications/{applicationID.Value}/guilds/{guildID.Value}/commands/{commandID.Value}")]
    Task<ApplicationCommand> GetGuildApplicationCommandAsync(
        Snowflake applicationID, Snowflake guildID,
        Snowflake commandID);

    /// <summary>
    ///     Edit a guild command.
    /// </summary>
    /// <remarks>
    ///     Updates for guild commands will be available immediately.
    ///     All fields are optional, but any fields provided will
    ///     entirely overwrite the existing values of those fields.
    /// </remarks>
    /// <param name="applicationID">
    ///     A <see cref="Snowflake" /> ID of application.
    /// </param>
    /// <param name="guildID">
    ///     A <see cref="Snowflake" /> ID of the guild to get commands from.
    /// </param>
    /// <param name="commandID">
    ///     A <see cref="Snowflake" /> command ID.
    /// </param>
    /// <param name="command">
    ///     New command state. Set only those properties
    ///     You would like to change.
    /// </param>
    /// <returns>
    ///     Returns an edited <see cref="ApplicationCommand" /> object.
    /// </returns>
    [Patch(
            "/applications/{applicationID.Value}/guilds/{guildID.Value}/commands/{commandID.Value}")]
    Task<ApplicationCommand> EditGuildApplicationCommandAsync(
        Snowflake applicationID, Snowflake guildID,
        Snowflake commandID,
        [Body] EditGuildApplicationCommandRequestModel command);

    /// <summary>
    ///     Delete a guild command.
    /// </summary>
    /// <param name="applicationID">
    ///     A <see cref="Snowflake" /> ID of application.
    /// </param>
    /// <param name="guildID">
    ///     A <see cref="Snowflake" /> ID of the guild to get commands from.
    /// </param>
    /// <param name="commandID">
    ///     A <see cref="Snowflake" /> command ID.
    /// </param>
    [Delete(
            "/applications/{applicationID.Value}/guilds/{guildID.Value}/commands/{commandID.Value}")]
    Task DeleteGuildApplicationCommandAsync(
        Snowflake applicationID, Snowflake guildID,
        Snowflake commandID);

    /// <summary>
    ///     Takes a list of application commands, overwriting
    ///     the existing command list for this application
    ///     for the targeted guild.
    /// </summary>
    /// <remarks>
    ///     This will overwrite all types of application commands:
    ///     slash commands, user commands, and message commands.
    /// </remarks>
    /// <param name="applicationID">
    ///     A <see cref="Snowflake" /> ID of application.
    /// </param>
    /// <param name="guildID">
    ///     A <see cref="Snowflake" /> ID of the guild to get commands from.
    /// </param>
    /// <param name="commands">
    ///     Commands to overwrite.
    /// </param>
    /// <returns>
    ///     An overwritten commands.
    /// </returns>
    [Put(
            "/applications/{applicationID.Value}/guilds/{guildID.Value}/commands")]
    Task<ApplicationCommand[]>
            BulkOverwriteGuildApplicationCommandsAsync(
                Snowflake applicationID, Snowflake guildID,
                [Body] IEnumerable<ApplicationCommand> commands);

    /// <summary>
    ///     Fetches permissions for all commands for your
    ///     application in a guild.
    /// </summary>
    /// <param name="applicationID">
    ///     A <see cref="Snowflake" /> ID of application.
    /// </param>
    /// <param name="guildID">
    ///     A <see cref="Snowflake" /> ID of the guild to get commands from.
    /// </param>
    [Get(
            "/applications/{applicationID.Value}/guilds/{guildID.Value}/commands/permissions")]
    Task<GuildApplicationCommandPermissions[]>
            GetGuildApplicationCommandPermissionsAsync(
                Snowflake applicationID, Snowflake guildID);

    /// <summary>
    ///     Fetches permissions for a specific command for your
    ///     application in a guild.
    /// </summary>
    /// <param name="applicationID">
    ///     A <see cref="Snowflake" /> ID of application.
    /// </param>
    /// <param name="guildID">
    ///     A <see cref="Snowflake" /> ID of the guild to get commands from.
    /// </param>
    /// <param name="commandID">
    ///     A <see cref="Snowflake" /> command ID.
    /// </param>
    [Get(
            "/applications/{applicationID.Value}/guilds/{guildID.Value}/commands/{commandID.Value}/permissions")]
    Task<GuildApplicationCommandPermissions>
            GetApplicationCommandPermissions(
                Snowflake applicationID, Snowflake guildID,
                Snowflake commandID);

    /// <summary>
    ///     Edits command permissions for a specific command for
    ///     your application in a guild. This endpoint will
    ///     overwrite existing permissions for the command
    ///     in that guild, meaning that only these permissions
    ///     that you have passed will be applied.
    /// </summary>
    /// <remarks>
    ///     You can add up to 100 permission overwrites for a
    ///     command. Deleting or renaming a command will
    ///     permanently delete all permissions for the command.
    ///     This endpoint requires authentication with a Bearer
    ///     token that has permission to manage the guild and its roles.
    ///     Read about it
    ///     <see
    ///         href="https://discord.com/developers/docs/interactions/application-commands#permissions">
    ///         there
    ///     </see>
    ///     .
    /// </remarks>
    /// <param name="applicationID">
    ///     A <see cref="Snowflake" /> ID of application.
    /// </param>
    /// <param name="guildID">
    ///     A <see cref="Snowflake" /> ID of the guild to get commands from.
    /// </param>
    /// <param name="commandID">
    ///     A <see cref="Snowflake" /> command ID.
    /// </param>
    /// <param name="permissions">
    ///     A new set of permissions is to be applied for a given command.
    /// </param>
    /// <returns>
    ///     Returns a new state of permissions of a given command in an
    ///     appropriate guild.
    /// </returns>
    [Put(
            "/applications/{applicationID.Value}/guilds/{guildID.Value}/commands/{commandID.Value}/permissions")]
    Task<GuildApplicationCommandPermissions>
            EditApplicationCommandPermissionsAsync(
                Snowflake applicationID, Snowflake guildID,
                Snowflake commandID,
                [Body]
                IEnumerable<ApplicationCommandPermissions>
                permissions);

    #endregion
}
