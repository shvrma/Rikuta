using JetBrains.Annotations;
using Rikuta.Models.Resources.Channel;

namespace Rikuta.Models.Interactions;

// TODO.
[PublicAPI]
public record PartialChannel(
    ) : IPartialEntity<PartialChannel, Channel>
{
    public static implicit operator PartialChannel(Channel entity)
        => throw new NotImplementedException();

    public static IPartialEntity<PartialChannel, Channel> ToPartialEntity(Channel entity)
        => throw new NotImplementedException();
}
