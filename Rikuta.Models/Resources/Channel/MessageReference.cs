using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

/// <summary>
///     Generic attributions to a previous message.
/// </summary>
/// <param name="MessageID">
///     ID of the originating message.
/// </param>
/// <param name="ChannelID">
///     ID of the originating message's channel. Optional when
///     creating a reply, but will always be present when receiving an
///     event/response that includes this data model.
/// </param>
/// <param name="GuildID">
///     ID of the originating message's guild.
/// </param>
/// <param name="FailIfNotExists">
///     When sending, whether to error if the referenced message doesn't
///     exist instead of sending as a normal (non-reply) message, default
///     true.
/// </param>
/// <seealso
///     href="https://discord.com/developers/docs/resources/channel#message-types">
///     Message Types
/// </seealso>
[PublicAPI]
public record MessageReference(
    [property: JsonPropertyNameOverride("message_id")]
    Optional<Snowflake> MessageID,
    [property: JsonPropertyNameOverride("channel_id")]
    Optional<Snowflake> ChannelID,
    [property: JsonPropertyNameOverride("guild_id")]
    Optional<Snowflake> GuildID,
    [property: JsonPropertyNameOverride("fail_if_not_exists")]
    Optional<bool> FailIfNotExists);
