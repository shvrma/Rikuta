using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

[PublicAPI]
public enum ForumLayout
{
    /// <summary>
    ///     No default has been set for forum channel.
    /// </summary>
    NotSet = 0,
    ListView    = 1,
    GalleryView = 2
}
