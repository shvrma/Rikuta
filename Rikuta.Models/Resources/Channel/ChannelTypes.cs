using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

[PublicAPI]
public enum ChannelTypes
{
    /// <summary>
    ///     A text channel within a server.
    /// </summary>
    GuildText = 0,
    DM         = 1,
    GuildVoice = 2,
    GroupDM    = 3,

    /// <summary>
    ///     An organizational category that contains up to 50 channels.
    /// </summary>
    GuildCategory = 4,

    /// <summary>
    ///     A channel that users can follow and cross-post into their
    ///     own server (formerly news channels).
    /// </summary>
    GuildAnnouncement = 5,

    /// <summary>
    ///     A temporary sub-channel within a
    ///     <see cref="GuildAnnouncement" /> channel.
    /// </summary>
    AnnouncementThread = 10,

    /// <summary>
    ///     A temporary sub-channel within a <see cref="GuildText" /> or
    ///     <see cref="GuildForum" /> channel.
    /// </summary>
    PublicThread = 11,

    PrivateThread = 12,

    /// <summary>
    ///     A voice channel for hosting events with an audience.
    /// </summary>
    /// <seealso
    ///     href="https://support.discord.com/hc/en-us/articles/1500005513722">
    ///     Stage Channels FAQ
    /// </seealso>
    GuildStageVoice = 13,

    /// <summary>
    ///     The channel in a
    ///     <see
    ///         href="https://support.discord.com/hc/en-us/articles/4406046651927-Discord-Student-Hubs-FAQ">
    ///         hub
    ///     </see> containing the listed servers.
    /// </summary>
    GuildDirectory = 14,

    /// <summary>
    ///     Channel that can only contain threads.
    /// </summary>
    GuildForum = 15,

    /// <summary>
    ///     Channel that can only contain threads, similar to
    ///     <see cref="GuildForum" /> channels.
    /// </summary>
    /// <remarks>
    ///     This channel type is still in active development. Avoid
    ///     implementing any features that are not documented here,
    ///     since they are subject to change without notice!
    /// </remarks>
    GuildMedia = 16
}
