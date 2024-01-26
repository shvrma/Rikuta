using JetBrains.Annotations;
using Rikuta.Models.Interactions.ApplicationCommands;

namespace Rikuta.Models.RequestModel.ApplicationCommands;

/// <summary>
///     Contain parameters used to pass in the
///     <see
///         href="https://discord.com/developers/docs/interactions/application-commands#edit-guild-application-command">
///         Edit Guild Application Command
///     </see>
///     endpoint.
/// </summary>
/// <seealso cref="ApplicationCommand" />
[PublicAPI]
public record EditGuildApplicationCommandRequestModel(
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
