using JetBrains.Annotations;

namespace Rikuta.Models.Resources.User;

/// <summary>
///     Premium types denote the level of premium a user has.
/// </summary>
/// <seealso href="https://discord.com/nitro">
///     Discord Nitro page
/// </seealso>
[PublicAPI]
public enum PremiumTypes
{
    None,
    NitroClassic,
    Nitro,
    NitroBasic
}
