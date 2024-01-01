namespace Rikuta.Models.Interactions.MessageComponents;

public enum MessageComponentTypes
{
    /// <summary>
    ///     Container for other components.
    /// </summary>
    ActionRow = 1,
    Button = 2,

    /// <summary>
    ///     Select menu for picking from defined text options.
    /// </summary>
    StringSelect = 3,
    TextInput         = 4,
    UserSelect        = 5,
    RoleSelect        = 6,
    MentionableSelect = 7,
    ChannelSelect     = 8
}
