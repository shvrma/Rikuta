using JetBrains.Annotations;
using Rikuta.Models.Monetization;
using Rikuta.Models.Permissions;
using Rikuta.Models.Resources;
using Rikuta.Models.Resources.Channel;
using Rikuta.Models.Resources.Guild;
using Rikuta.Models.Resources.User;

namespace Rikuta.Models.Interactions;

/// <summary>
///     A message that your application receives when a user uses an
///     application command or a message component.
/// </summary>
/// <remarks>
///     <paramref name="Member" /> is sent when the interaction is
///     invoked in a guild, and <paramref name="User" /> is sent when
///     invoked in a DM.
/// </remarks>
/// <param name="ID">
///     ID of the interaction.
/// </param>
/// <param name="ApplicationID">
///     ID of the application this interaction  is for.
/// </param>
/// <param name="InteractionType">
///     Type of interaction.
/// </param>
/// <param name="Data">
///     Interaction data payload.
///     <remarks>
///         Always present on
///         <see cref="InteractionType.ApplicationCommand" />,
///         <see cref="InteractionType.MessageComponent" />, and
///         <see cref="InteractionType.ModalSubmit" /> interaction
///         types. It is optional for future-proofing against new
///         interaction types. While this field is guaranteed to be
///         present for all mentioned interaction types, its structure
///         will vary.
///     </remarks>
/// </param>
/// <param name="GuildID">
///     Guild that the interaction was sent from.
/// </param>
/// <param name="Channel">
///     Channel that the interaction was sent from.
/// </param>
/// <param name="ChannelID">
///     Channel that the interaction was sent from.
/// </param>
/// <param name="Member">
///     Guild member data for the invoking user, including
///     permissions.
/// </param>
/// <param name="User">
///     User object for the invoking user, if invoked in a DM.
/// </param>
/// <param name="Token">
///     Continuation token for responding to the interaction
/// </param>
/// <param name="Version">
///     Read-only property, always equals to <see langword="1" />
/// </param>
/// <param name="Message">
///     For components, the message they were attached to.
/// </param>
/// <param name="AppPermissions">
///     Set of permissions the app or bot has within the channel the
///     interaction was sent from.
/// </param>
/// <param name="Locale">
///     Selected language of the invoking user.
///     <remarks>
///         Is not available for <see cref="InteractionType.Ping" />.
///     </remarks>
/// </param>
/// <param name="GuildLocale">
///     Guild's preferred locale, if invoked in a guild.
/// </param>
/// <param name="Entitlements">
///     For monetized apps, any entitlements for the invoking user,
///     representing access to premium SKUs.
/// </param>
/// <seealso cref="Locales" />
[PublicAPI]
public record Interaction(
    [property: JsonPropertyNameOverride("id")]
    Snowflake ID,
    [property: JsonPropertyNameOverride("application_id")]
    Snowflake ApplicationID,
    [property: JsonPropertyNameOverride("type")]
    InteractionType InteractionType,
    [property: JsonPropertyNameOverride("data")]
    Optional<JsonValue> Data,
    [property: JsonPropertyNameOverride("guild_id")]
    Optional<Snowflake> GuildID,
    [property: JsonPropertyNameOverride("channel")]
    Optional<Channel> Channel,
    [property: JsonPropertyNameOverride("channel_id")]
    Optional<Snowflake> ChannelID,
    [property: JsonPropertyNameOverride("member")]
    Optional<GuildMember> Member,
    [property: JsonPropertyNameOverride("user")]
    Optional<User> User,
    [property: JsonPropertyNameOverride("token")]
    string Token,
    [property: JsonPropertyNameOverride("version")]
    int Version,
    [property: JsonPropertyNameOverride("message")]
    Optional<Message> Message,
    [property: JsonPropertyNameOverride("app_permissions")]
    Optional<PermissionsString> AppPermissions,
    [property: JsonPropertyNameOverride("locale")]
    Optional<string> Locale,
    [property: JsonPropertyNameOverride("guild_locale")]
    Optional<string> GuildLocale,
    [property: JsonPropertyNameOverride("entitlements")]
    Entitlement[] Entitlements);
