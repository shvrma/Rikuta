using JetBrains.Annotations;
using Rikuta.Models.Resources.ApplicationRoleConnectionMetadata;

namespace Rikuta.Models.Resources.User;

/// <summary>
///     The role connection object that an application has attached
///     to a user.
/// </summary>
/// <param name="PlatformName">
///     The vanity name of the platform a bot has connected (max 50
///     characters).
/// </param>
/// <param name="PlatformUsername">
///     The username on the platform a bot has connected (max 100
///     characters).
/// </param>
/// <param name="Metadata">
///     Object mapping <see cref="ApplicationRoleConnectionMetadata" />
///     keys to their stringify value (max 100 characters) for the
///     user on the platform a bot has connected.
/// </param>
[PublicAPI]
public record ApplicationRoleConnection(
    [property: JsonPropertyNameOverride("platform_name")]
    string? PlatformName,
    [property: JsonPropertyNameOverride("platform_username")]
    string? PlatformUsername,
    [property: JsonPropertyNameOverride("metadata")]
    JsonValue Metadata);
