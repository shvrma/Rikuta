using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rikuta.Models.Serialization;

internal interface IJsonSerializer
{
    Memory<char> Serialize<ValueT>(ValueT value);

    ValueT Deserialize<ValueT>(Memory<char> input);
}
