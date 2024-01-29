using JetBrains.Annotations;

namespace Rikuta.Models.Interactions.ApplicationCommands;

/// <summary>
///     Represents an application command.
/// </summary>
/// <param name="ID">
///     Command identifier.
/// </param>
/// <param name="CommandType">
///     Type of command; defaults to
///     <see cref="ApplicationCommandTypes.ChatInput" />.
/// </param>
/// <param name="ApplicationID">
///     An application ID this command belongs to.
/// </param>
/// <param name="GuildID">
///     A guild ID this command is from; if omitted - the command is
///     global.
/// </param>
/// <param name="CommandName">
///     Name of command. 1-32 characters long.
/// </param>
/// <param name="LocalizedCommandNames">
///     Localization dictionary for <see cref="CommandName" /> field.
///     Values follow the same restrictions as
///     <see cref="CommandName" />.
/// </param>
/// <param name="Description">
///     Description for
///     <see cref="ApplicationCommandTypes.ChatInput" /> commands.
///     1-100 characters long. Empty for
///     <see cref="ApplicationCommandTypes.User" />
///     and <see cref="ApplicationCommandTypes.Message" /> commands.
/// </param>
/// <param name="LocalizedDescriptions">
///     Localization dictionary for <see cref="Description" /> field.
///     Values follow the same restrictions as
///     <see cref="Description" />.
/// </param>
/// <param name="Options">
///     Parameters for the command. Used only in
///     <see cref="ApplicationCommandTypes.ChatInput" /> commands;
///     max. of 25.
/// </param>
/// <param name="DefaultMemberPermissions">
///     Set of permissions for the user to be able to execute the
///     command.
/// </param>
/// <param name="IsDMAllowed">
///     Indicates whether the command is available in DMs with the app;
///     only for globally-scoped commands. By default, commands are
///     visible.
/// </param>
/// <param name="Version">
///     Auto-incrementing version identifier updated during
///     substantial record changes.
/// </param>
/// <param name="IsNsfw">
///     Indicates whether the command is age-restricted, defaults to
///     <c>false</c>.
/// </param>
/// <param name="LocalizedCommandName">
///     Represents localized command name according to client's
///     locale. This property is only included in response to
///     some endpoints, especially GET endpoints that return a
///     generalized list of all commands. You must not include
///     this in the request.
/// </param>
/// <param name="LocalizedDescription">
///     Represents localized command description according to
///     client's locale. This property is only included in response
///     to some endpoints, especially GET endpoints that return a
///     generalized list of all commands. You must not include
///     this in the request.
/// </param>
/// <remarks>
///     If <see cref="CommandType" /> is
///     <see cref="ApplicationCommandTypes.User" /> or
///     <see cref="ApplicationCommandTypes.Message" /> or
///     <see cref="Description" /> field is not allowed.
/// </remarks>
[PublicAPI]
public sealed record ApplicationCommand(
    [property: JsonPropertyNameOverride("id")]
    Snowflake ID,
    [property: JsonPropertyNameOverride("type")]
    Optional<ApplicationCommandTypes> CommandType,
    [property: JsonPropertyNameOverride("application_id")]
    Snowflake ApplicationID,
    [property: JsonPropertyNameOverride("guild_id")]
    Optional<Snowflake> GuildID,
    [property: JsonPropertyNameOverride("name")]
    string CommandName,
    [property: JsonPropertyNameOverride("name_localizations")]
    Optional<IDictionary<string, string>?> LocalizedCommandNames,
    [property: JsonPropertyNameOverride("description")]
    string Description,
    [property: JsonPropertyNameOverride("description_localizations")]
    Optional<IDictionary<string, string>?> LocalizedDescriptions,
    [property: JsonPropertyNameOverride("options")]
    Optional<ApplicationCommandOption[]> Options,
    [property: JsonPropertyNameOverride("default_member_permissions")]
    PermissionsString? DefaultMemberPermissions,
    [property: JsonPropertyNameOverride("dm_permission")]
    Optional<bool> IsDMAllowed,
    [property: JsonPropertyNameOverride("nsfw")]
    Optional<bool> IsNsfw,
    [property: JsonPropertyNameOverride("version")]
    Snowflake Version,
    [property: JsonPropertyNameOverride("name_localized")]
    Optional<string> LocalizedCommandName,
    [property: JsonPropertyNameOverride("description_localized")]
    Optional<string> LocalizedDescription)
{
    /// <summary>
    ///     This <see cref="PermissionsString" /> specifies minimal
    ///     possible <see cref="PermissionsString" />
    ///     for members to have to use this command.
    /// </summary>
    /// <remarks>
    ///     This is equal to the <c> null </c> string for the
    ///     <see cref="PermissionsString" />.
    /// </remarks>
    public static PermissionsString MinimalMemberPermissions
        => new(null);

    /// <summary>
    ///     Restrict everyone, except admins, from using the
    ///     command (if not overwritten).
    /// </summary>
    /// <remarks>
    ///     This is equal to the <c> 0 </c> string for the
    ///     <see cref="PermissionsString" />.
    ///     The string value of <c> 0 </c> acts differently from
    ///     the default permissions system.
    /// </remarks>
    public static PermissionsString RestrictEveryonePermissions
        => new("0");

    /// <summary>
    ///     Validates command name according to
    ///     <see
    ///         href="https://discord.com/developers/docs/interactions/application-commands#application-command-object-application-command-naming">
    ///         Discord's requirements
    ///     </see>
    ///     .
    /// </summary>
    /// <returns>
    ///     Whether the <see cref="CommandName" /> matches the
    ///     regex or not.
    /// </returns>
    /// <seealso cref="Validation.ChatInputCommandNameAndOptionName" />
    public bool ValidateCommandName()
        => Validation.ChatInputCommandNameAndOptionName()
                .IsMatch(input: CommandName);

    /// <summary>
    ///     Command options must be ordered such that required
    ///     options precede optional ones.
    /// </summary>
    public bool ValidateCommandOptions()
    {
        if (!Options.IsValueSet)
        {
            return true;
        }

        bool wasPreviousOptionRequired = true;
        foreach (ApplicationCommandOption option in Options.Value)
        {
            if (option.IsRequired && !wasPreviousOptionRequired)
            {
                return false;
            }

            wasPreviousOptionRequired = option.IsRequired;
        }

        return true;
    }
}
