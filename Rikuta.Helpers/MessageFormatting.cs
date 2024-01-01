using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rikuta.Helpers;

public static class MessageFormatting
{
    public static string FormatUser(string userID) => $"<@{userID}>";

    public static string FormatChannel(string channelID)
        => $"<#{channelID}>";

    public static string FormatRole(string roleID) => $"<@&{roleID}>";

    public static string FormatCommand(string commandName,
        string commandID)
        => $"</{commandName}:{commandID}>";

    public static string FormatSubcommand(
        string commandName,
        string subcommandName,
        string commandID)
        => $"</{commandName} {subcommandName}:{commandID}>";

    public static string FormatSubcommand(
        string commandName,
        string subcommandGroup,
        string subcommandName,
        string commandID)
        => $"</{commandName} {subcommandGroup} {subcommandName}:{commandID}>";

    public static string FormatStandartEmoji(char emoji)
        => emoji.ToString();

    public static string FormatCustomEmoji(string emojiName,
        string emojiID)
        => $"<:{emojiName}:{emojiID}>";

    public static string FormatCustomAnimatedEmoji(string emojiName,
        string emojiID)
        => $"<a:{emojiName}:{emojiID}>";

    public static string FormatTimestamp(DateTimeOffset timestamp)
        => $"<t:{timestamp.ToUnixTimeSeconds()}>";

    public static string FormatStyledTimestamp(
        DateTimeOffset timestamp, char style)
        => $"<t:{timestamp.ToUnixTimeSeconds()}:{style}>";

    public static string FormatGuildNavigation(string guildID,
        string type)
        => $"<{guildID}:{type}>";
}
