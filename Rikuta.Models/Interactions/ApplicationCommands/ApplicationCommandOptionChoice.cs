using JetBrains.Annotations;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.Interactions.ApplicationCommands;

/// <summary>
///     Represent a single choice of value for
///     <see cref="ApplicationCommandOption" />.
/// </summary>
/// <remarks>
///     If you specify choices for an option, they are the only valid
///     values for a user to pick.
/// </remarks>
/// <param name="Name">
///     Choice name. 1-100 character long.
/// </param>
/// <param name="LocalizedName">
///     Localization dictionary for the <see cref="Name" /> field.
///     Values follow the same restrictions.
/// </param>
/// <param name="Value">
///     Value for the choice up to 100 characters in length. It can
///     be a string, integer, or double - depending on the option type
///     that the choice belongs to.
/// </param>
[PublicAPI]
public sealed record ApplicationCommandOptionChoice(
    [property: JsonPropertyNameOverride("name")]
    string Name,
    [property: JsonPropertyNameOverride("name_localizations")]
    Optional<IDictionary<string, string>> LocalizedName,
    [property: JsonPropertyNameOverride("value")]
    IJsonValue Value);
