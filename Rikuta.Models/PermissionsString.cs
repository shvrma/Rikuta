using JetBrains.Annotations;

namespace Rikuta.Models;

/// <summary>
///     Represents a set of permissions given to some entity.
/// </summary>
[PublicAPI]
public record struct PermissionsString
{
    private long _value = 0;

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
        if (!long.TryParse(value, out _value)) _value = 0;
    }

    public static implicit operator long(PermissionsString permissions)
    {
        return permissions._value;
    }

    public static implicit operator string?(PermissionsString permissions)
    {
        return permissions._value == 0 ? default : permissions._value.ToString();
    }

    public void AddPermission(PermissionsFlags permission)
    {
        _value |= (long)permission;
    }

    public void RemovePermission(PermissionsFlags permission)
    {
        _value &= ~(long)permission;
    }
}
