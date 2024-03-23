using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

/// <summary>
///     Specifies number of thread-specific channel fields that are not
///     needed by other channel types.
/// </summary>
/// <param name="IsArchived">
///     Whether the thread is archived.
/// </param>
/// <param name="AutoArchiveDuration">
///     After specified minutes of inactivity, the thread will stop
///     showing in the channel list.
/// </param>
/// <param name="ArchiveTimestamp">
///     timestamp when the thread's archive status was last changed.
/// </param>
/// <param name="IsLocked">
///     Whether the thread is locked.
/// </param>
/// <param name="IsInvitable">
///     Whether non-moderators can add other non-moderators to a thread;
///     only available on private threads.
/// </param>
/// <param name="CreatedAt">
///     Timestamp when the thread was created; only populated for threads
///     created after 2022-01-09.
/// </param>
[PublicAPI]
public record ThreadMetadata(
    [property: JsonPropertyNameOverride("archived")]
    bool IsArchived,
    [property: JsonPropertyNameOverride("auto_archive_duration")]
    int AutoArchiveDuration,
    [property: JsonPropertyNameOverride("archive_timestamp")]
    DateTime ArchiveTimestamp,
    [property: JsonPropertyNameOverride("locked")]
    bool IsLocked,
    [property: JsonPropertyNameOverride("invitable")]
    Optional<bool> IsInvitable,
    [property: JsonPropertyNameOverride("create_timestamp")]
    DateTime CreatedAt);
