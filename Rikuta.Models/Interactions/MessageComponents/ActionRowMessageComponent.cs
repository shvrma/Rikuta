using JetBrains.Annotations;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <summary>
///     A non-interactive container component for other types of
///     components.
/// </summary>
/// <param name="Components">Components for this row.</param>
[PublicAPI]
public record ActionRowMessageComponent(
    IEnumerable<MessageComponent> Components)
        : MessageComponent(MessageComponentTypes.ActionRow)
{
    /// <summary>
    ///     Check whether this row is valid.
    /// </summary>
    /// <remarks>
    ///     Check if this row is a button row (a row can contain
    ///     up to 5 buttons) or a select menu (only one menu for
    ///     a row).
    /// </remarks>
    public bool ValidateRow()
    {
        bool isButtonRow = false;
        int increment = 0;
        foreach (MessageComponent component in Components)
        {
            // Action rows can not be nested.
            if (component.ComponentType == MessageComponentTypes.ActionRow)
            {
                return false;
            }

            // If the row contains at least one button, it is
            // considered as button row.
            if (component.ComponentType == MessageComponentTypes.Button)
            {
                isButtonRow = true;
            }

            if (isButtonRow)
            {
                // If it is a button row, check for an impostor
                // component in our buttons row.
                if (component.ComponentType != MessageComponentTypes.Button)
                    return false;

                // One row can hold a maximum of 5 buttons.
                if (increment > 5) return false;
            }
            else
            {
                // A row can hold only one select menu.
                if (increment > 1) return false;
            }

            increment++;
        }

        return true;
    }
}
