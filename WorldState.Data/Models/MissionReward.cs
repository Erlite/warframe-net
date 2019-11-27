﻿using System;

using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class MissionReward
    {
        [JsonProperty]
        public string[] Items { get; private set; }

        [JsonProperty("countedItems")]
        public SystemResource[] Resources { get; private set; }

        [JsonProperty]
        public int Credits { get; private set; }

        [JsonProperty]
        public Uri Thumbnail { get; private set; }

        [JsonProperty]
        public int Color { get; private set; }
    }
}
