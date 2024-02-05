using JetBrains.Annotations;
using Rikuta.Models.Resources.Channel;

namespace Rikuta.Models.Interactions;

// TODO.
[PublicAPI]
public record PartialMessage : IPartialEntity<PartialMessage, Message>
{
    public static implicit operator PartialMessage(Message entity)
        => throw new NotImplementedException();

    public static IPartialEntity<PartialMessage, Message>
            ToPartialEntity(Message entity)
        => throw new NotImplementedException();
}
