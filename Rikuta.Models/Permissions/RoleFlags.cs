using JetBrains.Annotations;

namespace Rikuta.Models.Permissions;

[PublicAPI]
[Flags]
public enum RoleFlags
{
    /// <summary>
    ///     Whether role can be selected by members in a Onboarding Prompt.
    /// </summary>
    IsInPrompt = 1 << 0
}
