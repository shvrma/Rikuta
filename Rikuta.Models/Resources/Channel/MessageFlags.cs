using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

[Flags]
[PublicAPI]
public enum MessageFlags
{
    /// <summary>
    ///     This message has been published to subscribed channels
    ///     (via Channel Following).
    /// </summary>
    Crossposted = 1 << 0,

    /// <summary>
    ///     This message originated from a message in another channel
    ///     (via Channel Following).
    /// </summary>
    IsCrosspost = 1 << 1,

    SuppressEmbeds = 1 << 2,

    /// <summary>
    ///     The source message for this crosspost has been deleted
    ///     (via Channel Following).
    /// </summary>
    SourceMessageDeleted = 1 << 3,

    IsUrgent    = 1 << 4,
    HasThread   = 1 << 5,
    IsEphemeral = 1 << 6,

    /// <summary>
    ///     This message is an Interaction Response and the bot is
    ///     "thinking".
    /// </summary>
    IsLoading = 1 << 7,

    /// <summary>
    ///     This message failed to mention some roles and add their
    ///     members to the thread.
    /// </summary>
    FailedToMentionSomeRolesInThread = 1 << 8,

    SuppressNotifications = 1 << 12,
    IsVoiceMessage        = 1 << 13
}
