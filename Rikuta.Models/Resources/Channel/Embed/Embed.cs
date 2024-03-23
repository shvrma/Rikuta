using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel.Embed;

/// <summary>
///     Represents a message's embedded content.
/// </summary>
/// <param name="Title">
///     Title of embed.
/// </param>
/// <param name="Type">
///     <see cref="EmbedTypes" /> type of embed (always "rich" for
///     webhook embeds). Embed types are "loosely defined" and should
///     be considered deprecated.
/// </param>
/// <param name="Description">
///     Description of embed.
/// </param>
/// <param name="Url">
///     URL of embed.
/// </param>
/// <param name="Timestamp">
///     Timestamp of embed content.
/// </param>
/// <param name="Color">
///     Color code of the embed.
/// </param>
/// <param name="Footer">
///     Footer information.
/// </param>
/// <param name="Image">
///     Image information.
/// </param>
/// <param name="Thumbnail">
///     Thumbnail information.
/// </param>
/// <param name="Video">
///     Video information.
/// </param>
/// <param name="Provider">
///     Provider information.
/// </param>
/// <param name="Author">
///     Author information.
/// </param>
/// <param name="Fields">
///     Fields information, max of 25.
/// </param>
[PublicAPI]
public record Embed(
    [property: JsonPropertyNameOverride("title")]
    Optional<string> Title,
    [property: JsonPropertyNameOverride("type")]
    [property:
        ValueProvider("Rikuta.Models.Resources.Channel.EmbedTypes")]
    Optional<string> Type,
    [property: JsonPropertyNameOverride("description")]
    Optional<string> Description,
    [property: JsonPropertyNameOverride("url")]
    Optional<Uri> Url,
    [property: JsonPropertyNameOverride("timestamp")]
    Optional<DateTime> Timestamp,
    [property: JsonPropertyNameOverride("color")]
    Optional<int> Color,
    [property: JsonPropertyNameOverride("footer")]
    Optional<EmbedFooter> Footer,
    [property: JsonPropertyNameOverride("image")]
    Optional<EmbedImage> Image,
    [property: JsonPropertyNameOverride("thumbnail")]
    Optional<EmbedThumbnail> Thumbnail,
    [property: JsonPropertyNameOverride("video")]
    Optional<EmbedVideo> Video,
    [property: JsonPropertyNameOverride("provider")]
    Optional<EmbedProvider> Provider,
    [property: JsonPropertyNameOverride("author")]
    Optional<EmbedAuthor> Author,
    [property: JsonPropertyNameOverride("fields")]
    Optional<EmbedField[]> Fields);
