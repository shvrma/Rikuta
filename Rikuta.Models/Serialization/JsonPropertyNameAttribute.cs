using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rikuta.Models.Serialization;

/// <summary>
/// Specifies the property name in the appropriate JSON object.
/// </summary>
/// <param name="name">Property name.</param>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public class JsonPropertyNameAttribute(string name) : Attribute;
