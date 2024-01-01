using JetBrains.Annotations;

namespace Rikuta.Models.Interactions.ApplicationCommands;

[PublicAPI]
public enum ApplicationCommandPermissionTypes
{
    Role    = 1,
    User    = 2,
    Channel = 3
}
