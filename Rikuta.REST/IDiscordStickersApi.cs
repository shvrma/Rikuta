using System.Net;
using Refit;
using Rikuta.Models;
using Rikuta.Models.RequestModel.Sticker;
using Rikuta.Models.Resources.Sticker;
using Rikuta.Models.ResponseModel.Sticker;

namespace Rikuta.REST;

/// <summary>
///     Handles interaction with discord API, specifically Sticker
///     managing.
/// </summary>
/// <seealso href="https://discord.com/developers/docs/resources/sticker">
///     Discord documentation on Stickers.
/// </seealso>
public interface IDiscordStickersApi
{
    /// <summary>
    ///     Returns a sticker object for the given
    ///     <paramref name="stickerID" />.
    /// </summary>
    /// <param name="stickerID">
    ///     ID of the sticker.
    /// </param>
    [Get("/stickers/{stickerID.Value}")]
    Task<Sticker> GetStickerAsync(Snowflake stickerID);

    /// <summary>
    ///     Returns a list of available sticker packs.
    /// </summary>
    [Get("/sticker-packs")]
    Task<ListStickerPacksResponseModel> ListStickerPacksAsync();

    /// <summary>
    ///     Returns an array of <see cref="Sticker" /> objects for the
    ///     given <paramref name="guildID" />.
    /// </summary>
    /// <remarks>
    ///     Includes <see cref="Sticker.User" /> fields if the bot has
    ///     the <c>CREATE_GUILD_EXPRESSIONS</c> or
    ///     <c>MANAGE_EMOJIS_AND_STICKERS</c> permission.
    /// </remarks>
    /// <param name="guildID">
    ///     The ID of the guild to fetch from.
    /// </param>
    [Get("/guilds/{guildID.Value}/stickers")]
    Task<Sticker[]> ListGuildStickersAsync(Snowflake guildID);

    /// <summary>
    ///     Returns a <see cref="Sticker" /> object for the given
    ///     <pararef cref="guildID" /> and
    ///     <paramref name="stickerID" />.
    /// </summary>
    /// <remarks>
    ///     Includes <see cref="Sticker.User" /> fields if the bot has
    ///     the <c>CREATE_GUILD_EXPRESSIONS</c> or
    ///     <c>MANAGE_EMOJIS_AND_STICKERS</c> permission.
    /// </remarks>
    /// <param name="guildID">
    ///     The ID of the guild to fetch from.
    /// </param>
    /// <param name="stickerID">
    ///     ID of the sticker.
    /// </param>
    [Get("/guilds/{guildID.Value}/stickers/{stickerID.Value}")]
    Task<Sticker> GetGuildStickerAsync(Snowflake guildID,
        Snowflake stickerID);

    /// <summary>
    ///     Create a new sticker for the guild. Returns
    ///     the new <see cref="Sticker" /> object on success.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Requires the CREATE_GUILD_EXPRESSIONS permission.
    ///         Fires a Guild Stickers Update Gateway event.
    ///     </para>
    ///     <para>
    ///         This endpoint supports the X-Audit-Log-Reason header.
    ///     </para>
    ///     <para>
    ///         Lottie stickers can only be uploaded on guilds that
    ///         have either the VERIFIED and/or the PARTNERED guild
    ///         feature.
    ///     </para>
    ///     <para>
    ///         Uploaded stickers are constrained to 5 seconds in
    ///         length for animated stickers, and 320 x 320 pixels.
    ///     </para>
    /// </remarks>
    /// <param name="guildID">
    ///     The ID of the guild to fetch from.
    /// </param>
    /// <param name="requestModel">
    ///     Params to create a sticker.
    /// </param>
    [Multipart]
    [Post("/guilds/{guildID.Value}/stickers")]
    Task<Sticker> CreateGuildStickerAsync(Snowflake guildID,
        [Body] CreateGuildStickerRequestModel requestModel);

    /// <summary>
    ///     Modify the given sticker.
    /// </summary>
    /// <remarks>
    ///     For stickers created by the current user, requires either
    ///     the CREATE_GUILD_EXPRESSIONS or MANAGE_GUILD_EXPRESSIONS
    ///     permission. For other stickers, requires the
    ///     MANAGE_GUILD_EXPRESSIONS permission.
    /// </remarks>
    /// <param name="guildID">
    ///     The ID of the guild to fetch from.
    /// </param>
    /// <param name="stickerID">
    ///     ID of the sticker.
    /// </param>
    /// <param name="requestModel">
    ///     Params to modify guild sticker.
    /// </param>
    /// <returns>
    ///     An updated <see cref="Sticker" /> object on success.
    /// </returns>
    [Patch("/guilds/{guildID.Value}/stickers/{stickerID.Value}")]
    Task<Sticker> ModifyGuildStickerAsync(Snowflake guildID,
        Snowflake stickerID,
        ModifyGuildStickerRequestModel requestModel);

    /// <summary>
    ///     Internal fetch implementation; not meant to be part of publicly
    ///     exposed API.
    /// </summary>
    /// <param name="guildID">
    ///     The ID of the guild to fetch from.
    /// </param>
    /// <param name="stickerID">
    ///     ID of the sticker.
    /// </param>
    [Delete("/guilds/{guildID.Value}/stickers/{stickerID.Value}")]
    protected Task<IApiResponse> DeleteGuildStickerInternalAsync(
        Snowflake guildID, Snowflake stickerID);

    /// <inheritdoc cref="DeleteGuildStickerInternalAsync" />
    /// <summary>
    ///     Delete the given sticker.
    /// </summary>
    /// <returns>
    ///     Whether deletion was a success or not.
    /// </returns>
    [Delete("/guilds/{guildID.Value}/stickers/{stickerID.Value}")]
    async Task<bool> DeleteGuildStickerAsync(Snowflake guildID,
        Snowflake stickerID)
    {
        IApiResponse response = await
                DeleteGuildStickerInternalAsync(
                        guildID: guildID,
                        stickerID: stickerID);

        return response.StatusCode == HttpStatusCode.NoContent;
    }
}
