using JetBrains.Annotations;
using Rikuta.Models.Resources.Guild;

namespace Rikuta.Models.Interactions;

// TODO.
[PublicAPI]
public record PartialGuildMember :
        IPartialEntity<PartialGuildMember, GuildMember>
{
    public static implicit operator PartialGuildMember(
        GuildMember entity)
        => throw new NotImplementedException();

    public static IPartialEntity<PartialGuildMember, GuildMember>
            ToPartialEntity(GuildMember entity)
        => throw new NotImplementedException();
}
