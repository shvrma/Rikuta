using JetBrains.Annotations;

namespace Rikuta.Models.Interactions.ApplicationCommands;

[PublicAPI]
public enum ApplicationCommandOptionTypes : byte
{
    Subcommand = 1,
    SubcommandGroup = 2,
    String = 3,
    Int = 4,
    Bool = 5,
    User = 6,

    /// <summary>
    ///     Includes all channel types and categories.
    /// </summary>
    Channel = 7,
    Role = 8,

    /// <summary>
    ///     Includes users and roles.
    /// </summary>
    Mentionable = 9,
    Number = 10,
    Attachment = 11
}
