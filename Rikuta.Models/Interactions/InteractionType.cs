using JetBrains.Annotations;

namespace Rikuta.Models.Interactions;

[PublicAPI]
public enum InteractionType
{
    Ping = 1,
    ApplicationCommand = 2,
    MessageComponent = 3,
    ApplicationCommandAutocomplete = 4,
    ModalSubmit = 5
}
