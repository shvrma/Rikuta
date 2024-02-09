using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

[Flags]
[PublicAPI]
public enum ChannelFlags : long
{
    /// <summary>
    ///     This thread is pinned to the top of its parent
    ///     <see cref="ChannelTypes.GuildForum" /> or
    ///     <see cref="ChannelTypes.GuildMedia" /> channel.
    /// </summary>
    Pinned = 1L << 1,

    /// <summary>
    ///     Whether a tag is required to be specified when creating a
    ///     thread in a <see cref="ChannelTypes.GuildForum" /> or a
    ///     <see cref="ChannelTypes.GuildMedia" /> channel. Tags are
    ///     specified in the <see cref="Channel.AppliedTags"/> field.
    /// </summary>
    RequireTag = 1L << 4,

    /// <summary>
    ///     When set hides the embedded media download options.
    ///     Available only for media channels.
    /// </summary>
    HideMediaDownloadOptions = 1L << 15
}
