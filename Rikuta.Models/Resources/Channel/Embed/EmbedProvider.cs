using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

/// <param name="Name">
///     Name of provider.
/// </param>
/// <param name="Url">
///     URL of provider.
/// </param>
[PublicAPI]
public record EmbedProvider(
    [property: JsonPropertyNameOverride("name")]
    Optional<string> Name,
    [property: JsonPropertyNameOverride("url")]
    Optional<Uri> Url);
