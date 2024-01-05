using JetBrains.Annotations;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <summary>
///     Component with custom ID.
/// </summary>
/// <param name="CustomID">
///     Developer-defined ID for component. Max 100 characters
///     in length.
///     <remarks>
///         Defined by the developer when sending the component,
///         and is returned in the interaction payload sent when a
///         user interacts with the component.
///         <paramref name="CustomID" /> must be unique per each
///         component.
///     </remarks>
/// </param>
/// <param name="ComponentType">
///     A <see cref="MessageComponentTypes" /> type of the component.
/// </param>
/// <seealso
///     href="https://discord.com/developers/docs/interactions/message-components#custom-id">
///     Discord docs
/// </seealso>
[PublicAPI]
public abstract record MessageComponentWithID(
    MessageComponentTypes ComponentType,
    [property: JsonPropertyNameOverride("custom_id")]
    string CustomID) : MessageComponent(ComponentType);
