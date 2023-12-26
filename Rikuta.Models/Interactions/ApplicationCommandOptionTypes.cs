namespace Rikuta.Models.Interactions;

public enum ApplicationCommandOptionTypes : byte
{
    SubCommand = 1,
    SubCommandGroup = 2,
    String = 3,
    Int = 4,
    Bool = 5,
    User = 6,

    /// <summary>
    /// Includes all channel types and categories.
    /// </summary>
    Channel = 7,
    Role = 8,
    Mentionable = 9,
    Number = 10,
    Attachment = 11
}