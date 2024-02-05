using System.Net;
using Refit;
using Rikuta.Models;
using Rikuta.Models.Api.User;
using Rikuta.Models.Resources.Channel;
using Rikuta.Models.Resources.Guild;
using Rikuta.Models.Resources.User;

namespace Rikuta.REST;

public interface IDiscordUsersApi
{
    /// <summary>
    ///     Returns the user object of the requester's account. For
    ///     OAuth2, this requires the 'identify' scope, which will
    ///     return the object without an email and, optionally, the
    ///     'email' scope, which returns the object with an email.
    /// </summary>
    [Get("/users/@me")]
    Task GetCurrentUserAsync();

    /// <summary>
    ///     Returns a <see cref="User" /> object for a given
    ///     <paramref name="userID" />.
    /// </summary>
    [Get("/users/{userID.Value}")]
    Task<User> GetUserAsync(Snowflake userID);

    /// <summary>
    ///     Modify the requester's user account settings.
    /// </summary>
    /// <remarks>
    ///     Returns a user object on success.
    ///     Fires a User Update Gateway event.
    /// </remarks>
    [Patch("/users/@me")]
    Task<User> ModifyCurrentUserAsync(
        [Body] ModifyCurrentUserPayload payload);

    /// <summary>
    ///     Returns a list of partial guild objects the current user
    ///     is a member of. For OAuth2, requires the 'guilds' scope.
    /// </summary>
    /// <param name="before">
    ///     Get guilds before this guild ID.
    /// </param>
    /// <param name="after">
    ///     Get guilds after this guild ID.
    /// </param>
    /// <param name="limit">
    ///     Max number of guilds to return (1-200).
    /// </param>
    /// <param name="withCounts">
    ///     Whether to include approximate member and presence counts
    ///     in response.
    /// </param>
    /// <remarks>
    ///     This endpoint returns 200 guilds by default, which is the
    ///     maximum number of guilds a non-bot user can join.
    ///     Therefore, pagination is not needed for integrations that
    ///     need to get a list of the users' guilds.
    /// </remarks>
    [Get("/users/@me/guilds")]
    Task<Guild> GetCurrentUserGuildsAsync(
        [AliasAs("before")] Snowflake? before = default(Snowflake?),
        [AliasAs("after")] Snowflake? after = default(Snowflake?),
        [AliasAs("limit")] int? limit = 200,
        [AliasAs("with_counts")] bool? withCounts = false);

    /// <summary>
    ///     Returns a <see cref="GuildMember" /> object for the current
    ///     user. Requires the 'guilds.members.read' OAuth2 scope.
    /// </summary>
    /// <param name="guildID">
    ///     The ID of the guild to fetch from.
    /// </param>
    [Get("/users/@me/guilds/{guildID.Value}/member")]
    Task<GuildMember> GetCurrentUserGuildMemberAsync(
        Snowflake guildID);

    [Delete("/users/@me/guilds/{guild.id}")]
    protected Task<IApiResponse> LeaveGuildInternalAsync(
        Snowflake guildID);

    /// <summary>
    ///     Leave a guild.
    /// </summary>
    /// <param name="guildID">
    ///     The ID of the guild to leave from.
    /// </param>
    /// <returns>
    ///     Whether the action was successful.
    /// </returns>
    async Task<bool> LeaveGuildAsync(Snowflake guildID)
    {
        IApiResponse response =
                await LeaveGuildInternalAsync(guildID);
        return response.StatusCode == HttpStatusCode.NoContent;
    }

    /// <summary>
    ///     Create a new DM channel with a user.
    /// </summary>
    /// <param name="payload">
    ///     Data to send to the endpoint.
    /// </param>
    /// <returns>
    ///     Returns a DM <see cref="Channel" /> object (if one already
    ///     exists, it will be returned instead).
    /// </returns>
    /// <remarks>
    ///     You should not use this endpoint to DM everyone in a
    ///     server about something.
    /// </remarks>
    [Post("/users/@me/channels")]
    Task<Channel> CreateDMAsync(CreateDMPayload payload);

    /// <summary>
    ///     Create a new group DM channel with multiple users.
    /// </summary>
    /// <param name="payload">
    ///     Data to send to the endpoint.
    /// </param>
    /// <returns>
    ///     Returns a DM <see cref="Channel" /> object.
    /// </returns>
    /// <remarks>
    ///     This endpoint is limited to 10 active group DMs.
    /// </remarks>
    [Post("/users/@me/channels")]
    Task<Channel> CreateGroupDMAsync(CreateGroupDMPayload payload);

    /// <summary>
    ///     Returns a list of connection objects.
    /// </summary>
    /// <remarks>
    ///     Requires the 'connections' OAuth2 scope.
    /// </remarks>
    [Get("/users/@me/connections")]
    Task<UserConnection[]> GetCurrentUserConnectionsAsync();

    /// <summary>
    ///     Returns the <see cref="ApplicationRoleConnection" /> for
    ///     the user.
    /// </summary>
    /// <param name="applicationID">
    ///     The ID of the application to fetch for.
    /// </param>
    /// <remarks>
    ///     Requires an OAuth2 access token with 'role_connections.write'
    ///     scope for the application specified in the path.
    /// </remarks>
    [Get(
            "/users/@me/applications/{applicationID.Value}/role-connection")]
    Task<ApplicationRoleConnection>
            GetCurrentUserApplicationRoleConnectionAsync(
                Snowflake applicationID);

    /// <summary>
    ///     Updates and returns the <see cref="ApplicationRoleConnection" />
    ///     for the user.
    /// </summary>
    /// <param name="applicationID">
    ///     The ID of the application to fetch for.
    /// </param>
    /// <remarks>
    ///     Requires an OAuth2 access token with 'role_connections.write'
    ///     scope for the application specified in the path.
    /// </remarks>
    [Put(
            "/users/@me/applications/{applicationID.Value}/role-connection")]
    Task<ApplicationRoleConnection>
            UpdateCurrentUserApplicationRoleConnectionAsync(
                Snowflake applicationID);
}
