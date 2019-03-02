﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using WorldState.Data.Enums;

namespace WorldState.Data.Models
{
    public class AlertMission
    {
        [JsonProperty]
        public string Type { get; private set; }

        [JsonProperty]
        public string Node { get; private set; }

        [JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
        public Faction Faction { get; private set; }

        [JsonProperty("archwingRequired")]
        public bool IsArchwingRequired { get; private set; }

        [JsonProperty("nightmare")]
        public bool IsNightmare { get; private set; }

        [JsonProperty("minEnemyLevel")]
        public int MinimumEnemyLevel { get; private set; }

        [JsonProperty("maxEnemyLevel")]
        public int MaximumEnemyLevel { get; private set; }

        [JsonProperty("maxWaveNum")]
        public int MaximumWaveNumber { get; private set; }

        [JsonProperty]
        public MissionReward Reward { get; private set; }
    }
}
