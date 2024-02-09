using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

/// <summary>
///     The default sort order type used to order posts in
///     <see cref="ChannelTypes.GuildForum" /> and
///     <see cref="ChannelTypes.GuildMedia" /> channels.
/// </summary>
[PublicAPI]
public enum ChannelSortOrderTypes
{
    /// <summary>
    ///     Sort forum posts by activity.
    /// </summary>
    LatestActivity = 1,

    /// <summary>
    ///     Sort forum posts by creation time (from most recent to oldest).
    /// </summary>
    CreationDate = 2
}
