using JetBrains.Annotations;

namespace Rikuta.Models;

/// <summary>
///     Specifies that type handles partial data about the entity it
///     derives from; thought and some properties aren't available.
/// </summary>
/// <remarks>
///     <para>
///         Excluded properties should be mentioned anywhere, basically
///         in XML-comments.
///     </para>
///     <para>
///         It should be mentioned that converting to the derived type
///         can result in a prohibited or mistaken state.
///     </para>
/// </remarks>
[PublicAPI]
public interface IPartialEntity
{
    public static Exception PartialDataUnavailableException =>
            new NotSupportedException(
                    "This data is not available on the partial entity.");
}
