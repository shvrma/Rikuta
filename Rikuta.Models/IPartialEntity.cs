using JetBrains.Annotations;

namespace Rikuta.Models;

/// <summary>
///     A marker interface specifies that type handles partial data
///     about the entity of type <typeparamref name="TOriginal" />;
///     thought some properties aren't available.
/// </summary>
/// <typeparam name="TPartial">
///     Type, implementing this interface.
/// </typeparam>
/// <typeparam name="TOriginal">
///     The original type, from whom this type inherits several
///     properties.
/// </typeparam>
/// <remarks>
///     Excluded properties should be mentioned anywhere, basically
///     in XML comments.
/// </remarks>
[PublicAPI]
public interface IPartialEntity<out TPartial, in TOriginal>
        where TPartial : IPartialEntity<TPartial, TOriginal>
{
    public Exception PartialDataUnavailableException =>
            new NotSupportedException(
                    "This data is not available on the partial entity.");

    static abstract implicit operator
            TPartial(TOriginal entity);

    static abstract IPartialEntity<TPartial, TOriginal>
            ToPartialEntity(TOriginal entity);
}
