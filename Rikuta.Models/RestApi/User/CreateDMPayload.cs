using JetBrains.Annotations;

namespace Rikuta.Models.Api.User;

/// <summary>
///     Contain parameters used to pass in the
///     <see
///         href="https://discord.com/developers/docs/resources/user#create-dm">
///         Create DM
///     </see>
///     endpoint.
/// </summary>
/// <param name="RecipientID">
///     The ID of recipient to open a DM channel with.
/// </param>
[PublicAPI]
public record CreateDMPayload(
    [property: JsonPropertyNameOverride("recipient_id")]
    Snowflake RecipientID);
