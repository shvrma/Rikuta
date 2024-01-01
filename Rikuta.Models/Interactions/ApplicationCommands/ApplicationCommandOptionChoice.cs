using JetBrains.Annotations;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.Interactions.ApplicationCommands;

/// <summary>
///     Represent a single choice of value for
///     <see cref="ApplicationCommandOption" />.
/// </summary>
/// <param name="Name">
///     Choice name.
///     <para>1-100 character long.</para>
/// </param>
/// <param name="LocalizedName">
///     Localization dictionary for the <see cref="Name" /> field.
///     Values follow the same restrictions.
/// </param>
/// <param name="Value">
///     Value for the choice, up to 100 characters long. It can be a
///     string, integer, or double.
/// </param>
[PublicAPI]
public sealed record ApplicationCommandOptionChoice(
    [property: JsonPropertyName("name")]
    string Name,
    [property: JsonPropertyName("name_localizations")]
    Optional<IDictionary<string, string>> LocalizedName,
    [property: JsonPropertyName("value")]
    object Value);
