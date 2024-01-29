using JetBrains.Annotations;
using Rikuta.Models.Permissions;
using Rikuta.Models.Resources;
using Rikuta.Models.Resources.Channel;

namespace Rikuta.Models.Interactions;

/// <summary>
/// 
/// </summary>
/// <param name="Users"></param>
/// <param name="Members"></param>
/// <param name="Roles"></param>
/// <param name="Channels"></param>
/// <param name="Messages"></param>
/// <param name="Attachments"></param>
[PublicAPI]
public record ResolvedData(
    [property: JsonPropertyNameOverride("users")]
    Optional<IDictionary<Snowflake, User>> Users,
    [property: JsonPropertyNameOverride("members")]
    Optional<IDictionary<Snowflake, PartialGuildMember>> Members,
    [property: JsonPropertyNameOverride("roles")]
    Optional<IDictionary<Snowflake, Role>> Roles,
    [property: JsonPropertyNameOverride("channels")]
    Optional<IDictionary<Snowflake, PartialChannel>> Channels,
    [property: JsonPropertyNameOverride("messages")]
    Optional<IDictionary<Snowflake, PartialMessage>> Messages,
    [property: JsonPropertyNameOverride("attachments")]
    Optional<IDictionary<Snowflake, Attachment>> Attachments);
