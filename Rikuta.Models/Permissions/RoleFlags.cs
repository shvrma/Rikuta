using JetBrains.Annotations;

namespace Rikuta.Models.Permissions;

[PublicAPI]
public enum RoleFlags
{
    /// <summary>
    ///     Whether role can be selected by members in a
    ///     <see
    ///         href="https://support.discord.com/hc/en-us/articles/11074987197975-Community-Onboarding-FAQ">
    ///         onboarding
    ///     </see> prompt.
    /// </summary>
    IsInPrompt = 1 << 0
}
