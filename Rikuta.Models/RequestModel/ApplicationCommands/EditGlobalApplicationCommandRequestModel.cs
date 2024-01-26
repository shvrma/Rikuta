using JetBrains.Annotations;
using Rikuta.Models.Interactions.ApplicationCommands;

namespace Rikuta.Models.RequestModel.ApplicationCommands;

/// <summary>
///     Contain parameters used to pass in the
///     <see
///         href="https://discord.com/developers/docs/interactions/application-commands#edit-global-application-command">
///         Edit Global Application Command
///     </see>
///     endpoint.
/// </summary>
/// <seealso cref="ApplicationCommand" />
[PublicAPI]
public record EditGlobalApplicationCommandRequestModel(
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
    [property: JsonPropertyNameOverride("nsfw")]
    Optional<bool> IsNsfwCommand);
