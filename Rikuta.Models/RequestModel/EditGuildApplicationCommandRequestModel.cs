using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rikuta.Models.Interactions;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.RequestModel;

/// <summary>
/// Contain parameters used to pass in the <see href="https://discord.com/developers/docs/interactions/application-commands#edit-guild-application-command">Edit Guild Application Command</see> endpoint.
/// </summary>
/// <param name="Name">	Name of command.</param>
/// <param name="LocalizedName">Localization dictionary for the <see cref="Name"/>.</param>
/// <param name="Description">Description for <see cref="ApplicationCommandTypes.ChatInput"/> commands.</param>
/// <param name="LocalizedDescription">Localization dictionary for the <see cref="Description"/>.</param>
/// <param name="Options">The parameters for the command</param>
/// <param name="DefaultRequiredMemberPermissions">Set of permissions for the user to be able to execute the command.</param>
/// <param name="Type">Command type.</param>
/// <param name="IsNsfwCommand">Indicates whether the command is age-restricted.</param>
[JsonSerializable]
public record EditGuildApplicationCommandRequestModel(
    [property: JsonPropertyName("name")]
    [property: StringLength(32, MinimumLength = 1)]
    string Name,
    
    [property: JsonPropertyName("name_localizations")]
    Optional<IDictionary<string, string>?> LocalizedName,
    
    [property: JsonPropertyName("description")]
    [property: StringLength(100, MinimumLength = 1)]
    Optional<string> Description,
    
    [property: JsonPropertyName("description_localizations")]
    Optional<IDictionary<string, string>?> LocalizedDescription,
    
    [property: JsonPropertyName("options")]
    Optional<ApplicationCommandOption[]> Options,
    
    [property: JsonPropertyName("default_member_permissions")]
    Optional<PermissionsSet> DefaultRequiredMemberPermissions,
    
    [property: JsonPropertyName("type")]
    Optional<ApplicationCommandTypes> Type,
    
    [property: JsonPropertyName("nsfw")]
    Optional<bool> IsNsfwCommand);
