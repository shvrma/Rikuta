using JetBrains.Annotations;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <summary>
///     Base type for all message components.
/// </summary>
/// <param name="ComponentType">
///     A type of the component.
/// </param>
[PublicAPI]
public abstract record MessageComponent(
    [property: JsonPropertyNameOverride("type")]
    MessageComponentTypes ComponentType);
