using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

/// <param name="Url">
///     Source URL of thumbnail (only supports http(s) and attachments).
/// </param>
/// <param name="ProxyUrl">
///     A proxied URL of the thumbnail.
/// </param>
/// <param name="Height">
///     Height of thumbnail.
/// </param>
/// <param name="Width">
///     Width of thumbnail.
/// </param>
[PublicAPI]
public record EmbedThumbnail(
    [property: JsonPropertyNameOverride("url")]
    Uri Url,
    [property: JsonPropertyNameOverride("proxy_url")]
    Optional<Uri> ProxyUrl,
    [property: JsonPropertyNameOverride("height")]
    Optional<int> Height,
    [property: JsonPropertyNameOverride("width")]
    Optional<int> Width);
