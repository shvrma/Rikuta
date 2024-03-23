using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

[PublicAPI]
public enum ChannelPermissionsOverwriteTypes
{
    /// <summary>
    ///     Permission overwrite applies to a role.
    /// </summary>
    ForRole = 0,

    /// <summary>
    ///     Permission overwrite applies to a user.
    /// </summary>
    ForMember = 1
}
