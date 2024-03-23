using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

/// <param name="Url">
///     Source URL of video.
/// </param>
/// <param name="ProxyUrl">
///     A proxied URL of the video.
/// </param>
/// <param name="Height">
///     Height of video.
/// </param>
/// <param name="Width">
///     Width of video.
/// </param>
[PublicAPI]
public record EmbedVideo(
    [property: JsonPropertyNameOverride("url")]
    Uri Url,
    [property: JsonPropertyNameOverride("proxy_url")]
    Optional<Uri> ProxyUrl,
    [property: JsonPropertyNameOverride("height")]
    Optional<int> Height,
    [property: JsonPropertyNameOverride("width")]
    Optional<int> Width);
