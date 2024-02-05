using JetBrains.Annotations;

namespace Rikuta.Models.Resources.User;

[PublicAPI]
[Flags]
public enum UserFlags
{
    Staff                   = 1 << 0,
    Partner                 = 1 << 1,
    HypeSquadMember         = 1 << 2,
    BugHunterLvl1           = 1 << 3,
    HypeSquadBravery        = 1 << 6,
    HypeSquadBrilliance     = 1 << 7,
    HypeSquadBalance        = 1 << 8,
    PremiumEarlySupporter   = 1 << 9,
    TeamUser                = 1 << 10,
    BugHunterLvl2           = 1 << 14,
    VerifiedBot             = 1 << 16,
    VerifiedEarlyDeveloper  = 1 << 17,
    CertifiedModerator      = 1 << 18,
    BotHttpOnlyInteractions = 1 << 19,
    ActiveDeveloper         = 1 << 22
}
