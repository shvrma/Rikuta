using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

[PublicAPI]
public record MessageActivity(
    [property: JsonPropertyNameOverride("type")]
    MessageActivityTypes Type,
    [property: JsonPropertyNameOverride("party_id")]
    Optional<string> PartyID);
