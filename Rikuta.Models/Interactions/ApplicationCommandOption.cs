using Rikuta.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rikuta.Models.Interactions;

/// <summary>
/// 
/// </summary>
/// <param name="OptionType"></param>
/// <param name="Name"></param>
/// <param name="LocalizedNames"></param>
/// <param name="Description"></param>
/// <param name="LocalizedDescription"></param>
/// <param name="IsRequired"></param>
/// <param name="Choices"></param>
/// <param name="Options"></param>
/// <param name="ChannelTypes"></param>
/// <param name="MinValue"></param>
/// <param name="MaxValue"></param>
/// <param name="MinLength"></param>
/// <param name="MaxLength"></param>
/// <param name="IsAutocomplete"></param>
public sealed record ApplicationCommandOption(
    [property: JsonRequired]
    [property: JsonPropertyName("type")]
    ApplicationCommandOptionTypes OptionType,

    [property: JsonRequired]
    [property: JsonPropertyName("name")]
    string Name,

    [property: JsonPropertyName("name")] 
    Optional<IDictionary<string, string>?> LocalizedNames,

    [property: JsonRequired]
    [property: JsonPropertyName("description")]
    string Description,

    [property: JsonPropertyName("description_localizations")]
    Optional<IDictionary<string, string>?> LocalizedDescription,

    [property: JsonPropertyName("required")]
    Optional<bool> IsRequired,

    [property: JsonPropertyName("choices")]
    Optional<IReadOnlyList<ApplicationCommandOptionChoice>> Choices,

    [property: JsonPropertyName("options")]
    Optional<ApplicationCommandOption[]> Options,

    [property: JsonPropertyName("channel_types")]
    Optional<ChannelTypes[]> ChannelTypes,

    [property: JsonPropertyName("min_value")]
    Optional<JsonValue> MinValue,

    [property: JsonPropertyName("max_value")]
    Optional<JsonValue> MaxValue,

    [property: JsonPropertyName("min_length")]
    Optional<short> MinLength,

    [property: JsonPropertyName("max_length")]
    Optional<short> MaxLength,

    [property: JsonPropertyName("autocomplete")]
    Optional<bool> IsAutocomplete)
{
    /// <summary>
    /// Validates option name according to <see href="https://discord.com/developers/docs/interactions/application-commands#application-command-object-application-command-naming">
    /// Discord's requirements</see>. 
    /// </summary>
    /// <returns>Whether the <see cref="Name"/> matches the regex or not.</returns>
    public bool FormatValidateOptionName()
    {
        return Validation.ChatInputCommandNameAndOptionName().IsMatch(Name);
    }
}
