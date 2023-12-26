using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rikuta.Models.Interactions;

/// <summary>
/// Represents an application command type.
/// </summary>
public enum ApplicationCommandTypes
{
    /// <summary>
    /// Text-based command that shows up when a user types /.
    /// </summary>
    ChatInput = 1,

    /// <summary>
    /// A UI-based command that shows up when you right-click or tap on a user.
    /// </summary>
    User = 2,

    /// <summary>
    /// A UI-based command that shows up when you right-click or tap on a message.
    /// </summary>
    Message = 3
}
