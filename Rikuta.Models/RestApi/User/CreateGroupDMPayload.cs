using JetBrains.Annotations;

namespace Rikuta.Models.Api.User;

/// <summary>
///     Contain parameters used to pass in the
///     <see
///         href="https://discord.com/developers/docs/resources/user#create-group-dm">
///         Create Group DM
///     </see>
///     endpoint.
/// </summary>
/// <param name="AccessTokens">
///     Access tokens of users that have granted your app
///     the 'gdm.join' scope.
/// </param>
/// <param name="Nicknames">
///     A dictionary of user ID's to their respective nicknames.
/// </param>
[PublicAPI]
public record CreateGroupDMPayload(
    [property: JsonPropertyNameOverride("access_tokens")]
    string[] AccessTokens,
    [property: JsonPropertyNameOverride("nicks")]
    IDictionary<Snowflake, string> Nicknames);
