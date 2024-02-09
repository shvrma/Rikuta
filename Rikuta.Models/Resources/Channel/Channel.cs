using JetBrains.Annotations;
using Rikuta.Models.Permissions;

namespace Rikuta.Models.Resources.Channel;

/// <summary>
///     Represents a guild or DM channel within Discord.
/// </summary>
/// <param name="ID">
///     The ID of this channel.
/// </param>
/// <param name="ChannelType">
///     The <see cref="ChannelType" /> of channel.
/// </param>
/// <param name="GuildID">
///     The ID of the guild (may be missing for some channel objects
///     received over gateway guild dispatches).
/// </param>
/// <param name="Position">
///     Sorting position of the channel.
/// </param>
/// <param name="PermissionOverwrites">
///     Explicit permission overwrites for members and roles.
/// </param>
/// <param name="Name">
///     The name of the channel (1-100 characters).
/// </param>
/// <param name="Topic">
///     The channel topic (0-4096 characters for
///     <see cref="ChannelTypes.GuildForum" />
///     and <see cref="ChannelTypes.GuildMedia" /> channels, 0-1024
///     characters for all others).
/// </param>
/// <param name="IsNsfw">Whether the channel is NSFW.</param>
/// <param name="LastMessageID">
///     The ID of the last message sent in this channel (or thread for
///     <see cref="ChannelTypes.GuildForum" /> or
///     <see cref="ChannelTypes.GuildMedia" /> channels) (may not point
///     to an existing or valid message or thread).
/// </param>
/// <param name="Bitrate">
///     The bitrate (in bits) of the voice channel.
/// </param>
/// <param name="UserLimit">
///     The user limit of the voice channel.
/// </param>
/// <param name="RateLimitPerUser">
///     Amount of seconds a user has to wait before sending another
///     message (0-21600); bots, as well as users with the permission
///     <see cref="PermissionsFlags.ManageMessages" /> or
///     <see cref="PermissionsFlags.ManageChannels" />, are unaffected.
///     Also applies to thread creation. Users can send one message and
///     create one thread during each
///     <paramref name="RateLimitPerUser" /> interval.
/// </param>
/// <param name="Recipients">
///     The recipients of the DM.
/// </param>
/// <param name="IconHash">
///     Icon hash of the group DM.
/// </param>
/// <param name="OwnerID">
///     ID of the creator of the group DM or thread.
/// </param>
/// <param name="ApplicationID">
///     Application id of the group DM creator if it is bot-created.
/// </param>
/// <param name="IsManaged">
///     For group DM channels: whether the channel is managed by an
///     application via the 'gdm.join' OAuth2 scope.
/// </param>
/// <param name="ParentID">
///     For guild channels: ID of the parent category for a channel (each
///     parent category can contain up to 50 channels), for threads: ID
///     of the text channel this thread was created.
/// </param>
/// <param name="LastPinTimestamp">
///     When the last pinned message was pinned. This may be null in
///     events such as GUILD_CREATE when a message is not pinned.
/// </param>
/// <param name="RtcRegion">
///     Voice region ID for the voice channel, automatic when set to
///     null.
/// </param>
/// <param name="VideoQualityMode">
///     The camera <see cref="VideoQualityModes" /> of the voice channel,
///     <see cref="VideoQualityModes.Auto" /> when not present.
/// </param>
/// <param name="ThreadMessageCount">
///     Number of messages (not including the initial message or deleted
///     messages) in a thread. For threads created before July 1, 2022,
///     the message count is inaccurate when it's greater than 50.
/// </param>
/// <param name="ThreadMemberCount">
///     An approximate count of users in a thread, stops counting at 50.
/// </param>
/// <param name="ThreadMetadata">
///     Thread-specific fields not needed by other channel types.
/// </param>
/// <param name="ThreadMember">
///     Thread member object for the current user, if they have joined
///     the thread, only included on certain API endpoints.
/// </param>
/// <param name="DefaultAutoArchiveDuration">
///     Default duration, copied onto newly created threads, in minutes,
///     threads will stop showing in the channel list after the specified
///     period of inactivity, can be set to: 60, 1440, 4320, 10080.
/// </param>
/// <param name="Permissions">
///     Computed permissions for the invoking user in the channel,
///     including overwrites, only included when part of the resolved
///     data received on a slash command interaction. This does not
///     include implicit permissions, which may need to be checked
///     separately.
/// </param>
/// <param name="ChannelFlags">
///     <see cref="ChannelFlags" /> combined as a bitfield.
/// </param>
/// <param name="TotalMessageSentInThread">
///     Number of messages ever sent in a thread, it's similar to
///     <paramref name="ThreadMessageCount" /> on message creation,
///     but will not decrement the number when a message is deleted.
/// </param>
/// <param name="AvailableTags">
///     The set of tags that can be used in a
///     <see cref="ChannelTypes.GuildForum" /> or a
///     <see cref="ChannelTypes.GuildMedia" /> channel.
/// </param>
/// <param name="AppliedTags">
///     The ID's of the set of tags that have been applied to a thread
///     in a <see cref="ChannelTypes.GuildForum" /> or a
///     <see cref="ChannelTypes.GuildMedia" /> channel.
/// </param>
/// <param name="DefaultReaction">
///     The emoji to show in the add reaction button on a thread in a
///     <see cref="ChannelTypes.GuildForum" /> or a
///     <see cref="ChannelTypes.GuildMedia" /> channel.
/// </param>
/// <param name="DefaultThreadRateLimit">
///     The initial <paramref name="RateLimitPerUser" /> to set on newly
///     created threads in a channel. This field is copied to the thread
///     at creation time and does not live update.
/// </param>
/// <param name="DefaultSortOrder">
///     The default <see cref="ChannelSortOrderTypes" /> type used to
///     order posts in <see cref="ChannelTypes.GuildForum" /> and
///     <see cref="ChannelTypes.GuildMedia" /> channels. Defaults to
///     null, which indicates a preferred sort order hasn't been set
///     by a channel admin.
/// </param>
/// <param name="DefaultForumLayout">
///     The default forum layout view used to display posts in
///     <see cref="ChannelTypes.GuildForum" /> channels. Defaults to
///     <see cref="ForumLayout.NotSet" />.
/// </param>
[PublicAPI]
public record Channel(
    [property: JsonPropertyNameOverride("id")]
    Snowflake ID,
    [property: JsonPropertyNameOverride("type")]
    ChannelTypes ChannelType,
    [property: JsonPropertyNameOverride("guild_id")]
    Optional<Snowflake> GuildID,
    [property: JsonPropertyNameOverride("position")]
    Optional<int> Position,
    [property: JsonPropertyNameOverride("permission_overwrites")]
    Optional<ChannelPermissionsOverwrite[]> PermissionOverwrites,
    [property: JsonPropertyNameOverride("name")]
    Optional<string?> Name,
    [property: JsonPropertyNameOverride("topic")]
    Optional<string?> Topic,
    [property: JsonPropertyNameOverride("nsfw")]
    Optional<bool> IsNsfw,
    [property: JsonPropertyNameOverride("last_message_id")]
    Optional<Snowflake?> LastMessageID,
    [property: JsonPropertyNameOverride("bitrate")]
    Optional<int> Bitrate,
    [property: JsonPropertyNameOverride("user_limit")]
    Optional<int> UserLimit,
    [property: JsonPropertyNameOverride("rate_limit_per_user")]
    Optional<int> RateLimitPerUser,
    [property: JsonPropertyNameOverride("recipients")]
    Optional<User.User[]> Recipients,
    [property: JsonPropertyNameOverride("icon")]
    Optional<string?> IconHash,
    [property: JsonPropertyNameOverride("owner_id")]
    Optional<Snowflake> OwnerID,
    [property: JsonPropertyNameOverride("application_id")]
    Optional<Snowflake> ApplicationID,
    [property: JsonPropertyNameOverride("managed")]
    Optional<bool> IsManaged,
    [property: JsonPropertyNameOverride("parent_id")]
    Optional<Snowflake?> ParentID,
    [property: JsonPropertyNameOverride("last_pin_timestamp")]
    Optional<DateTime?> LastPinTimestamp,
    [property: JsonPropertyNameOverride("rtc_region")]
    Optional<string?> RtcRegion,
    [property: JsonPropertyNameOverride("video_quality_mode")]
    Optional<VideoQualityModes> VideoQualityMode,
    [property: JsonPropertyNameOverride("message_count")]
    Optional<int> ThreadMessageCount,
    [property: JsonPropertyNameOverride("member_count")]
    Optional<int> ThreadMemberCount,
    [property: JsonPropertyNameOverride("thread_metadata")]
    Optional<ThreadMetadata> ThreadMetadata,
    [property: JsonPropertyNameOverride("member")]
    Optional<ThreadMember> ThreadMember,
    [property:
        JsonPropertyNameOverride("default_auto_archive_duration")]
    Optional<int> DefaultAutoArchiveDuration,
    [property: JsonPropertyNameOverride("permissions")]
    Optional<PermissionsString> Permissions,
    [property: JsonPropertyNameOverride("flags")]
    Optional<ChannelFlags> ChannelFlags,
    [property: JsonPropertyNameOverride("total_message_sent")]
    Optional<int> TotalMessageSentInThread,
    [property: JsonPropertyNameOverride("available_tags")]
    Optional<ForumTag[]> AvailableTags,
    [property: JsonPropertyNameOverride("applied_tags")]
    Optional<Snowflake[]> AppliedTags,
    [property: JsonPropertyNameOverride("default_reaction_emoji")]
    Optional<ChannelDefaultReaction?> DefaultReaction,
    [property:
        JsonPropertyNameOverride(
                "default_thread_rate_limit_per_user")]
    Optional<int> DefaultThreadRateLimit,
    [property: JsonPropertyNameOverride("default_sort_order")]
    Optional<ChannelSortOrderTypes?> DefaultSortOrder,
    [property: JsonPropertyNameOverride("default_forum_layout")]
    Optional<ForumLayout> DefaultForumLayout);
