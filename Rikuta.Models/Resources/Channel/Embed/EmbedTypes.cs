using JetBrains.Annotations;

namespace Rikuta.Models.Resources.Channel;

[PublicAPI]
public static class EmbedTypes
{
    public const string Rich     = "rich";
    public const string Image    = "image";
    public const string Video    = "video";
    public const string GifVideo = "gifv";
    public const string Article  = "article";
    public const string Link     = "link";
}
