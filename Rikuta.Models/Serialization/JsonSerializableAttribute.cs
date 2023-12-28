using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rikuta.Models.Serialization;

/// <summary>
/// Specifies that a given type is involved in JSON serialization.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class JsonSerializableAttribute : Attribute;