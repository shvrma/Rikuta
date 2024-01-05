using JetBrains.Annotations;
using Rikuta.Models.Interactions.ApplicationCommands;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.RequestModel.ApplicationCommands;

/// <summary>
///     Contain parameters used to pass in the
///     <see
///         href="https://discord.com/developers/docs/interactions/application-commands#create-global-application-command">
///         Create Global Application Command
///     </see>
///     endpoint.
/// </summary>
/// <inheritdoc cref="ApplicationCommand"/>
[PublicAPI]
public record CreateGlobalApplicationCommandRequestModel(
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
    [property: JsonPropertyNameOverride("dm_permission")]
    Optional<bool?> IsDMAllowed,
    [property: JsonPropertyNameOverride("type")]
    Optional<ApplicationCommandTypes> CommandType,
    [property: JsonPropertyNameOverride("nsfw")]
    Optional<bool> IsNsfwCommand);
