﻿using System.Threading.Tasks;
using Twitch.Net.Models;
using Twitch.Net.Models.Responses;

namespace Twitch.Net.Interfaces
{
    public interface IBitActions
    {

        Task<HelixResponse<HelixCheermote>> GetCheermotes(string userId = null);

    }
}