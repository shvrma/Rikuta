using JetBrains.Annotations;
using Rikuta.Models.Resources.Guild;

namespace Rikuta.Models.Resources.User;

/// <summary>
///     Represents some external service connection of a user.
/// </summary>
/// <param name="ID">
///     ID of the connection account.
/// </param>
/// <param name="Name">
///     The username of the connection account.
/// </param>
/// <param name="Type">
///     The service name string.
/// </param>
/// <param name="IsRevoked">
///     Whether the connection is revoked.
/// </param>
/// <param name="Integrations">
///     An array of partial server integrations.
/// </param>
/// <param name="IsVerified">
///     Whether the connection is verified.
/// </param>
/// <param name="IsFriendSyncEnabled">
///     Whether friend sync is enabled for this connection.
/// </param>
/// <param name="ShowActivity">
///     Whether activities related to this connection will be shown in
///     presence updates.
/// </param>
/// <param name="IsTwoWayLinked">
///     Whether this connection has a corresponding third party OAuth2
///     token.
/// </param>
/// <param name="Visibility">
///     Visibility of this connection.
/// </param>
/// <seealso cref="ConnectionServices" />
[PublicAPI]
public record UserConnection(
    [property: JsonPropertyNameOverride("id")]
    string ID,
    [property: JsonPropertyNameOverride("name")]
    string Name,
    [property: JsonPropertyNameOverride("type")]
    [property: ValueProvider(
            "Rikuta.Models.Resources.User.ConnectionServices")]
    string Type,
    [property: JsonPropertyNameOverride("revoked")]
    Optional<bool> IsRevoked,
    [property: JsonPropertyNameOverride("integrations")]
    Optional<GuildIntegration[]> Integrations,
    [property: JsonPropertyNameOverride("verified")]
    bool IsVerified,
    [property: JsonPropertyNameOverride("friend_sync")]
    bool IsFriendSyncEnabled,
    [property: JsonPropertyNameOverride("show_activity")]
    bool ShowActivity,
    [property: JsonPropertyNameOverride("two_way_link")]
    bool IsTwoWayLinked,
    [property: JsonPropertyNameOverride("visibility")]
    UserConnectionVisibilityTypes Visibility);
