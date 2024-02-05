using JetBrains.Annotations;

namespace Rikuta.Models.Resources.User;

/// <summary>
///     Service names for <see cref="UserConnection"/>.
/// </summary>
[PublicAPI]
public static class ConnectionServices
{
    public const string BattleNet       = "battlenet";
    public const string EBay            = "ebay";
    public const string EpicGames       = "epicgames";
    public const string Facebook        = "facebook";
    public const string GitHub          = "github";
    public const string Instagram       = "instagram";
    public const string LeagueOfLegends = "leagueoflegends";
    public const string PayPal          = "paypal";
    public const string PlayStation     = "playstation";
    public const string Reddit          = "reddit";
    public const string RiotGames       = "riotgames";
    public const string Spotify         = "spotify";

    /// <summary>
    ///     Service can no longer be added by users.
    /// </summary>
    public const string Skype = "skype";

    public const string Steam    = "steam";
    public const string TikTok   = "tiktok";
    public const string Twitch   = "twitch";
    public const string XTwitter = "twitter";
    public const string Xbox     = "xbox";
    public const string YouTube  = "youtube";
}
