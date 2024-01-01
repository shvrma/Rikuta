using JetBrains.Annotations;

namespace Rikuta.Models;

/// <summary>
///     Represents an optional payload field.
/// </summary>
/// <remarks>
///     The resulting JSON payload should exclude
///     values whose <see cref="IsValueSet" /> property is equal
///     to <see langword="false" />.
/// </remarks>
/// <typeparam name="T">
///     Type of underlying <see cref="Optional{T}" /> value.
/// </typeparam>
/// <param name="Value">
///     Value to be set as optional.
/// </param>
/// <param name="IsValueSet">
///     Explicit annotation of value availability.
/// </param>
[PublicAPI]
public readonly record struct Optional<T>(T Value, bool IsValueSet)
{
    public static Optional<T> Empty => default;

    public static implicit operator T(Optional<T> optional)
    {
        return optional.Value;
    }

    public static implicit operator Optional<T>(T value)
    {
        return new Optional<T>(value, true);
    }
}
