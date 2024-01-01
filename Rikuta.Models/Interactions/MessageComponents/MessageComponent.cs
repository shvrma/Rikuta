using JetBrains.Annotations;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <summary>
///     Base type for all message components.
///     Read about it
///     <see
///         href="https://discord.com/developers/docs/interactions/message-components">
///         there
///     </see>.
/// </summary>
/// <param name="Type">
///     A <see cref="MessageComponentTypes" /> type of the component.
/// </param>
[PublicAPI]
public abstract record MessageComponent(
    [property: JsonPropertyName("type")]
    MessageComponentTypes Type);
