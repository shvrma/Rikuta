using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rikuta.Helpers;

public static partial class Validation
{
    [GeneratedRegex(
        @"^[-_\\p{L}\\p{N}\\p{sc=Deva}\\p{sc=Thai}]{1,32}$", RegexOptions.Compiled)]
    public static partial Regex ChatInputCommandNameAndOptionName();
}
