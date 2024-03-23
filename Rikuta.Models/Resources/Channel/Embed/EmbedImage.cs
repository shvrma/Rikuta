using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel.Embed;

/// <param name="Url">
///     Source URL of image (only supports http(s) and attachments).
/// </param>
/// <param name="ProxyUrl">
///     A proxied URL of the image.
/// </param>
/// <param name="Height">
///     Height of image.
/// </param>
/// <param name="Width">
///     Width of image.
/// </param>
[PublicAPI]
public record EmbedImage(
    [property: JsonPropertyNameOverride("url")]
    Uri Url,
    [property: JsonPropertyNameOverride("proxy_url")]
    Optional<Uri> ProxyUrl,
    [property: JsonPropertyNameOverride("height")]
    Optional<int> Height,
    [property: JsonPropertyNameOverride("width")]
    Optional<int> Width);
