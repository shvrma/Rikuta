using System;
using System.Collections.Generic;
using System.Text;

namespace Rikuta.Helpers;

public static class RikutaConstants
{
    public const string VersionPathPrefix = "/v10";

    public static readonly Uri DiscordApiBaseUrl = 
        new("https://discord.com/api" + VersionPathPrefix);

    public static readonly Uri DiscordImageBaseUrl =
        new("https://cdn.discordapp.com");

    public static readonly DateTime DiscordEpoch = 
        new(2015, 1, 1, 1, 0, 0, DateTimeKind.Utc);
}
