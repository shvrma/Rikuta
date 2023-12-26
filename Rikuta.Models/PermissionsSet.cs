using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rikuta.Models;

/// <summary>
/// Represents a set of permissions given to some entity.
/// </summary>
public record struct PermissionsSet
{
    private long _value = 0;

    /// <summary>
    /// Initialize a new instance of type <see cref="PermissionsSet"/>.
    /// </summary>
    /// <param name="value">
    /// Value to be used. If <c>null</c> is passed, all permissions are restricted by default.
    /// </param>
    public PermissionsSet(string? value)
    {
        if (!long.TryParse(value, out _value))
        {
            _value = 0;
        }
    }

    public static implicit operator long(PermissionsSet permissions) 
        => permissions._value;

    public static implicit operator string?(PermissionsSet permissions) 
        => permissions._value == 0 ? default : permissions._value.ToString();

    public void AddPermission(PermissionsSetFlags permission) 
        => _value |= (long)permission;

    public void RemovePermission(PermissionsSetFlags permission) 
        => _value &= ~(long)permission;
}
