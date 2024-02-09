using JetBrains.Annotations;

namespace Rikuta.Models.Permissions;

/// <summary>
///     Represents a set of permissions given to some entity.
/// </summary>
/// <remarks>
///     Beware that permissions given may not always behave as you expect
///     it; given an example are
///     <see
///         href="https://discord.com/developers/docs/topics/permissions#implicit-permissions">
///         Implicit Permissions
///     </see>.
///     Read about permissions system on the same page as for
///     Implicit Permissions.
/// </remarks>
[PublicAPI]
public record struct PermissionsString
{
    private PermissionsFlags _value = 0;

    /// <summary>
    ///     Initialize a new instance of type
    ///     <see cref="PermissionsString" />.
    /// </summary>
    /// <param name="value">
    ///     Value to be used. If <c>null</c> is passed, all
    ///     permissions are restricted by default.
    /// </param>
    public PermissionsString(string? value)
    {
        if (long.TryParse(value, out long convertedValue))
        {
            _value = (PermissionsFlags)convertedValue;
        }
    }

    public static implicit operator PermissionsFlags(
        PermissionsString permissions)
        => permissions._value;

    public static implicit operator string?(
        PermissionsString permissions)
        => permissions._value == 0
                ? default(string)
                : permissions._value.ToString();

    public void AddPermission(PermissionsFlags permission)
    {
        _value |= permission;
    }

    public void RemovePermission(PermissionsFlags permission)
    {
        _value &= ~permission;
    }
}
