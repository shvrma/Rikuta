using JetBrains.Annotations;
using Rikuta.Models.Resources.Guild;

namespace Rikuta.Models.Resources.Channel;

/// <summary>
///     Contains information about a user that has joined a thread.
/// </summary>
/// <param name="ThreadID">
///     ID of the thread.
/// </param>
/// <param name="UserID">
///     ID of the user.
/// </param>
/// <param name="JoinedAt">
///     Time the user last joined the thread.
/// </param>
/// <param name="Flags">
///     Any user-thread settings, currently only used for notifications.
/// </param>
/// <param name="Member">
///     Additional information about the user.
/// </param>
[PublicAPI]
public record ThreadMember(
    [property: JsonPropertyNameOverride("id")]
    Optional<Snowflake> ThreadID,
    [property: JsonPropertyNameOverride("user_id")]
    Optional<Snowflake> UserID,
    [property: JsonPropertyNameOverride("join_timestamp")]
    DateTime JoinedAt,
    // TODO: Wtf are those flags?
    [property: JsonPropertyNameOverride("flags")]
    int Flags,
    [property: JsonPropertyNameOverride("member")]
    Optional<GuildMember> Member);
