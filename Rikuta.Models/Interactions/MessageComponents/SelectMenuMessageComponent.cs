using JetBrains.Annotations;
using Rikuta.Models.Resources;
using Rikuta.Models.Resources.Channel;
using Rikuta.Models.Serialization;

namespace Rikuta.Models.Interactions.MessageComponents;

/// <summary>
///     Select menus are interactive components that allow users
///     to select one or more options from a dropdown list in
///     messages.
/// </summary>
/// <param name="CustomID">
///     A <see cref="Snowflake" /> ID for the select menu; max
///     100 characters.
/// </param>
/// <param name="Options">
///     Are required for
///     <see cref="MessageComponentTypes.StringSelect" />
///     menus. And unavailable for all other select menu components.
///     Specified choices in a select menu. Max. 25.
/// </param>
/// <param name="ChannelTypes">
///     Can only be used for
///     <see cref="MessageComponentTypes.ChannelSelect" />
///     menu components. List of channel types to include in the
///     channel select component.
/// </param>
/// <param name="Placeholder">
///     Placeholder text if nothing is selected; max 150
///     characters.
/// </param>
/// <param name="DefaultValues">
///     Parameter is only available for auto-populated select
///     menu components, which include
///     <see cref="MessageComponentTypes.UserSelect" />,
///     <see cref="MessageComponentTypes.RoleSelect" />,
///     <see cref="MessageComponentTypes.MentionableSelect" />,
///     and <see cref="MessageComponentTypes.ChannelSelect" />
///     components.
///     List of default values for auto-populated select menu
///     components; number of default values must be in the
///     range defined by <paramref name="MinValues" /> and
///     <paramref name="MaxValues" />.
/// </param>
/// <param name="MinValues">
///     Minimum number of items that must be chosen (defaults to 1);
///     min. 0, max. 25.
/// </param>
/// <param name="MaxValues">
///     Maximum number of items that can be chosen (defaults to 1);
///     max. 25.
/// </param>
/// <param name="IsDisabled">
///     Whether select menu is disabled.
/// </param>
[PublicAPI]
public record SelectMenuMessageComponent(
    MessageComponentTypes Type,
    string CustomID,
    [property: JsonPropertyNameOverride("options")]
    Optional<SelectOption[]> Options,
    [property: JsonPropertyNameOverride("channel_types")]
    Optional<ChannelTypes[]> ChannelTypes,
    [property: JsonPropertyNameOverride("placeholder")]
    Optional<string> Placeholder,
    [property: JsonPropertyNameOverride("default_values")]
    Optional<SelectDefaultValue[]> DefaultValues,
    [property: JsonPropertyNameOverride("min_values")]
    Optional<int> MinValues,
    [property: JsonPropertyNameOverride("max_values")]
    Optional<int> MaxValues,
    [property: JsonPropertyNameOverride("disabled")]
    Optional<bool> IsDisabled) : MessageComponentWithID(
        Type, CustomID);
