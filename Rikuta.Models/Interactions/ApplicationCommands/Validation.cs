using System.Text.RegularExpressions;
using JetBrains.Annotations;

namespace Rikuta.Models.Interactions.ApplicationCommands;

[PublicAPI]
public static partial class Validation
{
    [GeneratedRegex(
            @"^[-_\\p{L}\\p{N}\\p{sc=Deva}\\p{sc=Thai}]{1,32}$",
            RegexOptions.Compiled)]
    public static partial Regex ChatInputCommandNameAndOptionName();
}
