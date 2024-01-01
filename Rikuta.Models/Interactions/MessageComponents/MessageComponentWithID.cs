using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <summary>
///     A <paramref name="CustomID" /> property is defined by
///     the developer when sending the component payload,
///     and is returned in the interaction payload sent when
///     a user interacts with the component.
/// </summary>
/// <remarks>
///     <paramref name="CustomID" /> must be unique per each
///     component.
/// </remarks>
/// <param name="CustomID">
///     Developer-defined ID for component. Max 100 characters
///     in length.
/// </param>
/// <param name="Type">
///     A <see cref="MessageComponentTypes" /> type of the component.
/// </param>
[PublicAPI]
public abstract record MessageComponentWithID(
    MessageComponentTypes Type,
    [property: JsonPropertyName("custom_id")]
    string CustomID) : MessageComponent(Type);
