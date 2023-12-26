using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rikuta.Models;

/// <summary>
/// Represents an optional payload field. 
/// </summary>
/// <remarks>
/// The resulting JSON payload should exclude 
/// values whose <see cref="IsValueSet"/> property is equal to <see langword="false"/>. 
/// </remarks>
/// <param name="Value">
/// Value to be set as optional. 
/// </param>
/// <param name="IsValueSet">
/// Explicit annotation of value availability. 
/// </param>
public record struct Optional<ValueT>(ValueT Value, bool IsValueSet)
{
    public static Optional<ValueT> Empty => new();

    public static implicit operator ValueT?(Optional<ValueT> optional) => optional.Value;

    public static implicit operator Optional<ValueT>(ValueT value) => new(value, true);
}
