using JetBrains.Annotations;
using Rikuta.Models.Interactions.MessageComponents;

namespace Rikuta.Models.Interactions.InteractionData;

/// <summary>
///     An interaction data sent in
///     <see cref="InteractionType.ModalSubmit" />
///     interaction.
/// </summary>
/// <param name="CustomID">
///     The <see cref="MessageComponentWithID.CustomID" /> of modal.
/// </param>
/// <param name="Components">
///     The values submitted by the user.
/// </param>
[PublicAPI]
public record ModalSubmitData(
    [property: JsonPropertyNameOverride("custom_id")]
    string CustomID,
    [property: JsonPropertyNameOverride("components")]
    MessageComponent[] Components);
