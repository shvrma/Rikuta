using JetBrains.Annotations;
using Rikuta.Models.Permissions;

namespace Rikuta.Models.Resources.Guild;

[PublicAPI]
public record Guild(
    Snowflake ID,
    string Name,
    Optional<string> IconHash,
    string? SplashHash,
    string? DiscoverySplashHash,
    Optional<bool> IsOwnerPresent,
    Snowflake OwnerID,
    Optional<PermissionsString> Permissions,
    Optional<string?> VoiceRegion,
    Snowflake? AfkChannelID,
    int AfkTimeout,
    Optional<bool> IsWidgetEnabled,
    Optional<Snowflake?> WidgetChannelID,
    VerificationLevels VerificationLevel,
    MessageNotificationsLevels DefaultMessageNotificationsLevel,
    ExplicitContentFilterLevels ExplicitContentFilterLevel,
    Role[] Roles,
    Emoji.Emoji[] Emojis,
    [ValueProvider("Rikuta.Models.Resources.Guild.GuildFeatures")]
    string[] GuildFeatures,
    MfaLevels MfaLevel,
    Snowflake? ApplicationID,
    Snowflake? SystemChannelID,
    SystemChannelFlags SystemChannelFlags,
    Snowflake? RulesChannelID,
    Optional<int?> MaxPresences,
    Optional<int> MaxMembers,
    string? VanityUrlCode,
    string? Description,
    string? BannerHash,
    PremiumTiers PremiumTier,
    int PremiumSubscriptionCount,
    string PreferredLocale,
    Snowflake? PublicUpdatesChannelID,
    Optional<int> MaxVideoChannelUsers,
    Optional<int> MaxStageIVideoChannelUsers,
    Optional<int> ApproximateMemberCount,
    Optional<int> ApproximatePresenceCount,
    Optional<WelcomeScreen> WelcomeScreen,
    NsfwLevels NsfwLevel);
