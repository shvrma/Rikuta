using JetBrains.Annotations;
using Rikuta.Models.Interactions.MessageComponents;

namespace Rikuta.Models.Interactions.InteractionData;

/// <summary>
///     An interaction data sent in
///     <see cref="InteractionType.MessageComponent" />
///     interaction.
/// </summary>
/// <param name="CustomID">
///     The <see cref="MessageComponentWithID.CustomID" /> of the
///     component.
/// </param>
/// <param name="ComponentType">
///     The type of the component.
/// </param>
/// <param name="Values">
///     Values the user selected in a select menu component.
///     Always present for select menu components.
/// </param>
/// <param name="Resolved">
///     Resolved entities from selected options.
/// </param>
[PublicAPI]
public record MessageComponentData(
    [property: JsonPropertyNameOverride("custom_id")]
    string CustomID,
    [property: JsonPropertyNameOverride("component_type")]
    MessageComponentTypes ComponentType,
    [property: JsonPropertyNameOverride("custom_id")]
    Optional<SelectOption[]> Values,
    [property: JsonPropertyNameOverride("custom_id")]
    Optional<ResolvedData> Resolved);
