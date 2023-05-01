﻿using Team121GBCapstoneProject.Models;
using Team121GBCapstoneProject.Models.DTO;

namespace Team121GBCapstoneProject.Services.Abstract
{
    public interface IsteamService
    {
        Task<SteamUser> GetSteamUser(string id);
        public SteamGamesDTO GetGames(string steamId);
        public SteamAchievementsDTO GetSteamAchievements(string userID, string gameid);
    }
}
