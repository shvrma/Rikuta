using JetBrains.Annotations;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.Permissions;

/// <summary>
///     Roles represent a set of permissions attached to a
///     group of users.
/// </summary>
/// <remarks>
///     The @everyone role has the same ID as the guild it
///     belongs to.
/// </remarks>
/// <param name="ID">
///     Role <see cref="Snowflake" /> ID.
/// </param>
/// <param name="Name">
///     Role name.
/// </param>
/// <param name="Color">
///     Integer representation of hexadecimal color code.
///     Roles without colors (color == 0) do not count towards
///     the final computed color in the user list.
/// </param>
/// <param name="Hoist">
///     Whether this role is pinned in the user listing.
/// </param>
/// <param name="Icon">
///     Role icon hash. Read about it
///     <see
///         href="https://discord.com/developers/docs/reference#image-formatting">
///         there
///     </see>.
/// </param>
/// <param name="UnicodeEmoji">
///     Role Unicode emoji.
/// </param>
/// <param name="Position">
///     Position of this role
/// </param>
/// <param name="Permissions">
///     Permissions for this role.
/// </param>
/// <param name="Managed">
///     Whether this role is managed by an integration
/// </param>
/// <param name="Mentionable">
///     Whether this role is mentionable
/// </param>
/// <param name="Tags">
///     The tags this role has
/// </param>
/// <param name="Flags">
///     A <see cref="RoleFlags" /> combined as a bitfield.
/// </param>
[PublicAPI]
public record Role(
    [property: JsonPropertyName("id")]
    Snowflake ID,
    [property: JsonPropertyName("name")]
    string Name,
    [property: JsonPropertyName("color")]
    int Color,
    [property: JsonPropertyName("hoist")]
    bool Hoist,
    [property: JsonPropertyName("icon")]
    Optional<string?> Icon,
    [property: JsonPropertyName("unicode_emoji")]
    Optional<char?> UnicodeEmoji,
    [property: JsonPropertyName("position")]
    int Position,
    [property: JsonPropertyName("permissions")]
    PermissionsString Permissions,
    [property: JsonPropertyName("managed")]
    bool Managed,
    [property: JsonPropertyName("mentionable")]
    bool Mentionable,
    [property: JsonPropertyName("tags")]
    Optional<RoleTags> Tags,
    [property: JsonPropertyName("flags")]
    int Flags);
