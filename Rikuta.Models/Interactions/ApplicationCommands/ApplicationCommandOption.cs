using JetBrains.Annotations;
using Rikuta.Helpers;
using Rikuta.Models.Resources;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.Interactions.ApplicationCommands;

/// <summary>
///     Represents a single option for
///     <see cref="ApplicationCommand" />.
///     <para>
///         Is only reliable for
///         <see cref="ApplicationCommandTypes.ChatInput" />.
///     </para>
/// </summary>
/// <param name="OptionType">
///     Type of option.
/// </param>
/// <param name="Name">
///     Option name.
///     <para>1-32-character long.</para>
/// </param>
/// <param name="LocalizedNames">
///     Localization dictionary for the <see cref="Name" />.
///     <para>
///         Values follow the same restrictions as <see cref="Name" />.
///     </para>
/// </param>
/// <param name="Description">
///     Option description.
///     <para>1-100-character long.</para>
/// </param>
/// <param name="LocalizedDescription">
///     Localization dictionary for the <see cref="Description" />
///     field.
///     <para>
///         Values follow the same restrictions as
///         <see cref="Description" />.
///     </para>
/// </param>
/// <param name="IsRequired">
///     Whether the parameter is required or optional, default
///     to <c>false</c>.
/// </param>
/// <param name="Choices">
///     Choices for <see cref="ApplicationCommandOptionTypes.String" />,
///     <see cref="ApplicationCommandOptionTypes.Int" />, and
///     <see cref="ApplicationCommandOptionTypes.Number" />
///     types for the user to pick from, max. 25.
/// </param>
/// <param name="Options">
///     Options for subcommand. If the <see cref="OptionType" /> is a
///     <see cref="ApplicationCommandOptionTypes.Subcommand" />
///     or <see cref="ApplicationCommandOptionTypes.SubcommandGroup" />,
///     these nested options will be the
///     parameters.
/// </param>
/// <param name="ChannelTypes">
///     If the <see cref="OptionType" /> is a
///     <see cref="ApplicationCommandOptionTypes.Channel" />,
///     the channels shown will be restricted to these types.
/// </param>
/// <param name="MinValue">
///     If the option is a
///     <see cref="ApplicationCommandOptionTypes.Int" />
///     or <see cref="ApplicationCommandOptionTypes.Number" />
///     type, specifies the minimum value permitted.
/// </param>
/// <param name="MaxValue">
///     If the option is a
///     <see cref="ApplicationCommandOptionTypes.Int" />
///     or <see cref="ApplicationCommandOptionTypes.Number" />
///     type, specifies the maximum value permitted.
/// </param>
/// <param name="MinLength">
///     For option type
///     <see cref="ApplicationCommandOptionTypes.String" />,
///     the minimum allowed length (minimum of 0, maximum of 6000).
/// </param>
/// <param name="MaxLength">
///     For option type
///     <see cref="ApplicationCommandOptionTypes.String" />,
///     the maximum allowed length (minimum of 1, maximum of 6000).
/// </param>
/// <param name="IsAutocomplete">
///     Whether autocomplete interactions are enabled for this
///     <see cref="ApplicationCommandOptionTypes.String" />,
///     <see cref="ApplicationCommandOptionTypes.Int" />, or
///     <see cref="ApplicationCommandOptionTypes.Number" />
///     type option.
/// </param>
[PublicAPI]
public sealed record ApplicationCommandOption(
    [property: JsonPropertyName("type")]
    ApplicationCommandOptionTypes OptionType,
    [property: JsonPropertyName("name")]
    string Name,
    [property: JsonPropertyName("name")]
    Optional<IDictionary<string, string>?> LocalizedNames,
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
    Optional<object> MinValue,
    [property: JsonPropertyName("max_value")]
    Optional<object> MaxValue,
    [property: JsonPropertyName("min_length")]
    Optional<short> MinLength,
    [property: JsonPropertyName("max_length")]
    Optional<short> MaxLength,
    [property: JsonPropertyName("autocomplete")]
    Optional<bool> IsAutocomplete)
{
    /// <summary>
    ///     Validates option name according to
    ///     <see
    ///         href="https://discord.com/developers/docs/interactions/application-commands#application-command-object-application-command-naming">
    ///         Discord's requirements
    ///     </see>.
    /// </summary>
    /// <returns>
    ///     Whether the <see cref="Name" /> matches the regex or not.
    /// </returns>
    public bool ValidateOptionName()
        => Validation.ChatInputCommandNameAndOptionName()
            .IsMatch(Name);
}
