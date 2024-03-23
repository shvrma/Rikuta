using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

[PublicAPI]
public record MessageReactionCountDetails(
    [property: JsonPropertyNameOverride("burst")]
    int Burst,
    [property: JsonPropertyNameOverride("normal")]
    int Normal);
