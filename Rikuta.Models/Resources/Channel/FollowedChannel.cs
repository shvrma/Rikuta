using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

/// <param name="ChannelID">
///     Source channel ID.
/// </param>
/// <param name="WebhookID">
///     Created target webhook ID.
/// </param>
[PublicAPI]
public record FollowedChannel(
    [property: JsonPropertyNameOverride("channel_id")]
    Snowflake ChannelID,
    [property: JsonPropertyNameOverride("webhook_id")]
    Snowflake WebhookID);
