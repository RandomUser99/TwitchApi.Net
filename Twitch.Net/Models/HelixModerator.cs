﻿using System.Text.Json.Serialization;

namespace Twitch.Net.Models
{
    public class HelixModerator
    {

        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

    }
}