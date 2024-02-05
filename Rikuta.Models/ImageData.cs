using System.Text;
using JetBrains.Annotations;

namespace Rikuta.Models;

/// <summary>
///     Data URI scheme representation for images.
/// </summary>
/// <remarks>
///     Only JPG, GIF, and PNG formats are supported.
/// </remarks>
[PublicAPI]
public record ImageData
{
    public ImageData(
        string contentType,
        ReadOnlyMemory<byte> content)
    {
        if (contentType.ToLower() is not "image/jpeg"
            and not "image/gif"
            and not "image/png")
        {
            throw new ArgumentException(
                    "Only JPG, GIF, and PNG formats are supported.",
                    nameof(contentType));
        }

        ContentType = contentType;
        Content = content;
    }

    /// <summary>
    ///     A Mime type of the image.
    /// </summary>
    public string ContentType { get; }

    /// <summary>
    ///     Image content.
    /// </summary>
    public ReadOnlyMemory<byte> Content { get; }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();

        stringBuilder.Append("data:");
        stringBuilder.Append(ContentType);
        stringBuilder.Append(";base64,");
        stringBuilder.Append(Convert.ToBase64String(Content.Span));

        return stringBuilder.ToString();
    }
}
