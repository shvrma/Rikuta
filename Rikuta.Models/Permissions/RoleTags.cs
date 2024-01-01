﻿using JetBrains.Annotations;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.Permissions;

/// <summary>
///     Tag list for specific <see cref="Role" />.
/// </summary>
/// <remarks>
///     Optional properties of type <see cref="object" /> are
///     treated as booleans. Their underlying value is always
///     null, but if the <see cref="Optional{T}.IsValueSet" />
///     property is set to true, it means the corresponding
///     JSON property is also true, otherwise, it's false.
///     Read about it
///     <see
///         href="https://discord.com/developers/docs/topics/permissions#role-object-role-tags-structure">
///         there
///     </see>
///     .
/// </remarks>
/// <param name="BotID">
///     If present, the ID of the bot this role belongs to.
/// </param>
/// <param name="IntegrationID">
///     If present, the ID of the integration this role belongs
///     to.
/// </param>
/// <param name="IsBoostersRole">
///     Whether this is the guild's Booster role.
/// </param>
/// <param name="SubscriptionListingID">
///     The id of this role's subscription sku and listing.
/// </param>
/// <param name="AvailableForPurchase">
///     Whether this role is available for purchase.
/// </param>
/// <param name="IsGuildLinked">
///     Whether this role is a guild's linked role.
/// </param>
[PublicAPI]
public record RoleTags(
    [property: JsonPropertyName("bot_id")]
    Optional<Snowflake> BotID,
    [property: JsonPropertyName("integration_id")]
    Optional<Snowflake> IntegrationID,
    [property: JsonPropertyName("premium_subscriber")]
    Optional<object> IsBoostersRole,
    [property: JsonPropertyName("subscription_listing_id")]
    Optional<Snowflake> SubscriptionListingID,
    [property: JsonPropertyName("available_for_purchase")]
    Optional<object> AvailableForPurchase,
    [property: JsonPropertyName("guild_connections")]
    Optional<object> IsGuildLinked);