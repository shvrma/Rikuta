﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rikuta.Models;

/// <summary>
/// 
/// </summary>
public enum PermissionsSetFlags : long
{
    CreateInstantInvite = 1 << 0,
    KickMembers = 1 << 1,
    BanMembers = 1 << 2,
    Administrator = 1 << 3,
    ManageChannels = 1 << 4,
    ManageGuild = 1 << 5,
    AddReactions = 1 << 6,
    ViewAuditLog = 1 << 7,
    PrioritySpeaker = 1 << 8,
    Stream = 1 << 9,
    ViewChannel = 1 << 10,
    SendMessages = 1 << 11,
    SendTtsMessages = 1 << 12,
    ManageMessages = 1 << 13,
    EmbedLinks = 1 << 14,
    AttachFiles = 1 << 15,
    ReadMessageHistory = 1 << 16,
    MentionEveryone = 1 << 17,
    UseExternalEmojis = 1 << 18,
    ViewGuildInsights = 1 << 19,
    Connect = 1 << 20,
    Speak = 1 << 21,
    MuteMembers = 1 << 22,
    DeafenMembers = 1 << 23,
    MoveMembers = 1 << 24,
    UseVoiceActivityDetection = 1 << 25,
    ChangeNickname = 1 << 26,
    ManageNicknames = 1 << 27,
    ManageRoles = 1 << 28,
    ManageWebhooks = 1 << 29,
    ManageGuildExpressions = 1 << 30,
    UseApplicationCommands = 1 << 31,
    RequestToSpeak = (long)1 << 32,
    ManageEvents = (long)1 << 33,
    ManageThreads = (long)1 << 34,
    CreatePublicThreads = (long)1 << 35,
    CreatePrivateThreads = (long)1 << 36,
    UseExternalStickers = (long)1 << 37,
    SendMessagesInThreads = (long)1 << 38,
    UseEmbeddedActivities = (long)1 << 39,
    ModerateMembers = (long)1 << 40,
    ViewCreatorMonetizationAnalytics = (long)1 << 41,
    UseSoundbar = (long)1 << 42,
    CreateGuildExpressions = (long)1 << 43,
    CreateEvents = (long)1 << 44,
    UseExternalSounds = (long)1 << 45,
    SendVoiceMessages = (long)1 << 46
}
