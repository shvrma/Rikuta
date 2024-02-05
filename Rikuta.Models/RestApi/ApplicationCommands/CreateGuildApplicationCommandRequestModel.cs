using JetBrains.Annotations;
using Rikuta.Models.Interactions.ApplicationCommands;
using Rikuta.Models.Permissions;

namespace Rikuta.Models.RestApi.ApplicationCommands;

/// <summary>
///     Contain parameters used to pass in the
///     <see
///         href="https://discord.com/developers/docs/interactions/application-commands#create-guild-application-command">
///         Create Guild Application Command
///     </see>
///     endpoint.
/// </summary>
/// <param name="Name">
///     Name of command.
/// </param>
/// <param name="LocalizedName">
///     Localization dictionary for the <see cref="Name" />.
/// </param>
/// <param name="Description">
///     Description for
///     <see cref="ApplicationCommandTypes.ChatInput" /> commands.
/// </param>
/// <param name="LocalizedDescription">
///     Localization dictionary for the <see cref="Description" />.
/// </param>
/// <param name="Options">
///     The parameters for the command
/// </param>
/// <param name="DefaultRequiredMemberPermissions">
///     Set of permissions for the user to be able to execute
///     the command.
/// </param>
/// <param name="Type">
///     Command type.
/// </param>
/// <param name="IsNsfwCommand">
///     Indicates whether the command is age-restricted.
/// </param>
[PublicAPI]
public record CreateGuildApplicationCommandRequestModel(
    [property: JsonPropertyNameOverride("name")]
    string Name,
    [property: JsonPropertyNameOverride("name_localizations")]
    Optional<IDictionary<string, string>?> LocalizedName,
    [property: JsonPropertyNameOverride("description")]
    Optional<string> Description,
    [property: JsonPropertyNameOverride("description_localizations")]
    Optional<IDictionary<string, string>?> LocalizedDescription,
    [property: JsonPropertyNameOverride("options")]
    Optional<ApplicationCommandOption[]> Options,
    [property: JsonPropertyNameOverride("default_member_permissions")]
    Optional<PermissionsString> DefaultRequiredMemberPermissions,
    [property: JsonPropertyNameOverride("type")]
    Optional<ApplicationCommandTypes> Type,
    [property: JsonPropertyNameOverride("nsfw")]
    Optional<bool> IsNsfwCommand);
