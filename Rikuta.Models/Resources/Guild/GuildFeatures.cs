using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Guild;

// TODO.
[PublicAPI]
public static class GuildFeatures
{
    public static string AnimatedBanner => "ANIMATED_BANNER";
    public static string AnimatedIcon => "ANIMATED_ICON";

    public static string NewApplicationCommandPermissions
        => "APPLICATION_COMMAND_PERMISSIONS_V2";

    public static string AutoModeration => "AUTO_MODERATION";
    public static string Banner => "BANNER";
    public static string CommunityGuild => "COMMUNITY";

    public static string MonetizationEnabled
        => "CREATOR_MONETIZABLE_PROVISIONAL";

    public static string CreatorStorePage => "CREATOR_STORE_PAGE";
    public static string SupportServer => "DEVELOPER_SUPPORT_SERVER";
    public static string Discoverable => "DISCOVERABLE";
    public static string Featurable => "FEATURABLE";
    public static string DisabledInvites => "INVITES_DISABLED";
    public static string InviteSplash => "INVITE_SPLASH";

    public static string MemberVerificationGateEnabled
        => "MEMBER_VERIFICATION_GATE_ENABLED";

    public static string MoreStickers => "MORE_STICKERS";
    public static string News => "NEWS";
    public static string Partnered => "PARTNERED";
    public static string PreviewEnabled => "PREVIEW_ENABLED";
    public static string RaidAlertsDisabled => "RAID_ALERTS_DISABLED";
    public static string RoleIcons => "ROLE_ICONS";

    public static string RoleSubscriptionAvailableForPurchase
        => "ROLE_SUBSCRIPTIONS_AVAILABLE_FOR_PURCHASE";

    public static string RoleSubscriptionEnabled
        => "ROLE_SUBSCRIPTIONS_ENABLED";

    public static string TicketedEventsEnabled
        => "TICKETED_EVENTS_ENABLED";

    public static string VanityUrl => "VANITY_URL";
    public static string Verified => "VERIFIED";
    public static string VipRegions => "VIP_REGIONS";

    public static string WelcomeScreenEnabled
        => "WELCOME_SCREEN_ENABLED";
}
