using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rikuta.Models;

public enum ChannelTypes : byte
{
    GuildText = 0, 
    DM = 1, 
    GuildVoice = 2, 
    GroupDM = 3, 
    GuildCategory = 4, 
    GuildAnnouncement = 5, 

    AnnouncementThread = 10, 
    PublicThread = 11, 
    PrivateThread = 12, 
    GuildStageVoice = 13, 
    GuildDirectory = 14,
    GuildForum = 15,
    GuildMedia = 16
}
