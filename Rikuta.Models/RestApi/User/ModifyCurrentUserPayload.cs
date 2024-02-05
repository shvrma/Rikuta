using JetBrains.Annotations;

namespace Rikuta.Models.Api.User;

/// <summary>
///     Contain parameters used to pass in the
///     <see
///         href="https://discord.com/developers/docs/resources/user#modify-current-user">
///         Modify Current User
///     </see>
///     endpoint.
/// </summary>
/// <param name="Username">
///     User's username, if changed may cause the user's
///     discriminator to be randomized.
/// </param>
/// <param name="Avatar">
///     If passed, modifies the user's avatar.
/// </param>
[PublicAPI]
public record ModifyCurrentUserPayload(
    [property: JsonPropertyNameOverride("username")]
    Optional<string> Username,
    [property: JsonPropertyNameOverride("avatar")]
    Optional<ImageData?> Avatar);
