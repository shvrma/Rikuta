using JetBrains.Annotations;
using Rikuta.Models.Interactions.ApplicationCommands;

namespace Rikuta.Models.Interactions.InteractionData;

/// <summary>
///     An interaction data sent in
///     <see cref="InteractionType.ApplicationCommand" /> and
///     <see cref="InteractionType.ApplicationCommandAutocomplete" />
///     interactions.
/// </summary>
/// <param name="ID">
///     The <see cref="ApplicationCommand.ID" /> of the invoked
///     command.
/// </param>
/// <param name="Name">
///     The <see cref="ApplicationCommand.CommandName" /> of the
///     invoked command.
/// </param>
/// <param name="CommandType">
///     The <see cref="ApplicationCommand.CommandType" /> of the
///     invoked command.
/// </param>
/// <param name="Resolved">
///     Resolved entities for this interaction. Contains resolved
///     users, roles, channels, and attachments.
/// </param>
/// <param name="Options">
///     The params + values from the user for the command.
///     <remarks>
///         Options can be partial. The application will receive
///         partial data for existing user input as long as the
///         appropriate options pass client-side validation.
///     </remarks>
/// </param>
/// <param name="GuildID">
///     The id of the guild the command is registered to
/// </param>
/// <param name="TargetID">
///     ID of the user or message targeted by a
///     <see cref="ApplicationCommandTypes.User" /> or
///     <see cref="ApplicationCommandTypes.Message" /> command.
/// </param>
[PublicAPI]
public record ApplicationCommandData(
    [property: JsonPropertyNameOverride("id")]
    Snowflake ID,
    [property: JsonPropertyNameOverride("name")]
    string Name,
    [property: JsonPropertyNameOverride("type")]
    ApplicationCommandTypes CommandType,
    [property: JsonPropertyNameOverride("resolved")]
    Optional<ResolvedData> Resolved,
    [property: JsonPropertyNameOverride("options")]
    Optional<ApplicationCommandOptionData[]> Options,
    [property: JsonPropertyNameOverride("guild_id")]
    Optional<Snowflake> GuildID,
    [property: JsonPropertyNameOverride("target_id")]
    Optional<Snowflake> TargetID);
