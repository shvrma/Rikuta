using JetBrains.Annotations;

namespace Rikuta.Models;

/// <summary>
///     An identifier object that is used across Discord's internal
///     system.
/// </summary>
/// <param name="Value">An underlying value of Snowflake.</param>
[PublicAPI]
public readonly record struct Snowflake(
    ulong Value)
{
    public override string ToString()
        => Value.ToString();
}
