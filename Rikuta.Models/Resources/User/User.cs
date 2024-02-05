using JetBrains.Annotations;

namespace Rikuta.Models.Resources.User;

/// <summary>
///     Represents a single user within Discord.
/// </summary>
/// <param name="ID">
///     The user's id
/// </param>
/// <param name="Username">
///     The user's username, not unique across the platform.
/// </param>
/// <param name="Discriminator">
///     The user's Discord-tag.
/// </param>
/// <param name="GlobalName">
///     The user's display name, if it is set. For bots, this is the
///     application name.
/// </param>
/// <param name="AvatarHash">
///     The user's avatar hash.
/// </param>
/// <param name="IsBot">
///     Whether the user belongs to an OAuth2 application
/// </param>
/// <param name="IsSystem">
///     Whether the user is an Official Discord System user (part of
///     the urgent message system).
/// </param>
/// <param name="IsMfaEnabled">
///     Whether the user has two factors enabled on their account.
/// </param>
/// <param name="BannerHash">
///     The user's banner hash.
/// </param>
/// <param name="AccentColor">
///     The user's banner color.
/// </param>
/// <param name="Locale">
///     The user's chosen language option.
/// </param>
/// <param name="IsEmailVerified">
///     Whether the email on this account has been verified. Requires
///     <c>email</c> OAuth2 scope to obtain.
/// </param>
/// <param name="Email">
///     The user's email. Requires <c>email</c> OAuth2 scope to obtain.
/// </param>
/// <param name="UserFlags">
///     The flags on a user's account.
/// </param>
/// <param name="PremiumType">
///     The type of Nitro subscription on a user's account.
/// </param>
/// <param name="PublicFlags">
///     The public flags on a user's account.
/// </param>
/// <param name="AvatarDecorationHash">
///     The user's avatar decoration hash.
/// </param>
[PublicAPI]
public record User(
    [property: JsonPropertyNameOverride("id")]
    Snowflake ID,
    [property: JsonPropertyNameOverride("username")]
    string Username,
    [property: JsonPropertyNameOverride("discriminator")]
    string Discriminator,
    [property: JsonPropertyNameOverride("global_name")]
    string? GlobalName,
    [property: JsonPropertyNameOverride("avatar")]
    string? AvatarHash,
    [property: JsonPropertyNameOverride("bot")]
    Optional<bool> IsBot,
    [property: JsonPropertyNameOverride("system")]
    Optional<bool> IsSystem,
    [property: JsonPropertyNameOverride("mfa_enabled")]
    Optional<bool> IsMfaEnabled,
    [property: JsonPropertyNameOverride("banner")]
    Optional<string?> BannerHash,
    [property: JsonPropertyNameOverride("accent_color")]
    Optional<int?> AccentColor,
    [property: JsonPropertyNameOverride("locale")]
    [property: ValueProvider("Rikuta.Models.Locales")]
    Optional<string> Locale,
    [property: JsonPropertyNameOverride("verified")]
    Optional<bool> IsEmailVerified,
    [property: JsonPropertyNameOverride("email")]
    Optional<string?> Email,
    [property: JsonPropertyNameOverride("flags")]
    Optional<UserFlags> UserFlags,
    [property: JsonPropertyNameOverride("premium_type")]
    Optional<PremiumTypes> PremiumType,
    [property: JsonPropertyNameOverride("public_flags")]
    Optional<UserFlags> PublicFlags,
    [property: JsonPropertyNameOverride("avatar_decoration")]
    Optional<string?> AvatarDecorationHash);
