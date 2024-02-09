using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

[PublicAPI]
public enum MessageActivityTypes
{
    Join        = 1,
    Spectate    = 2,
    Listen      = 3,
    JoinRequest = 5
}
