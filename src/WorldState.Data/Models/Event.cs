﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WorldState.Data.Models
{
    public class Event
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty("active")]
        public bool IsActive { get; private set; }

        [JsonProperty]
        public string Description { get; private set; }

        [JsonProperty]
        public string Tooltip { get; private set; }

        [JsonProperty]
        public List<string> ConcurrentNodes { get; private set; }

        [JsonProperty]
        public string VictimNode { get; private set; }

        [JsonProperty]
        public List<MissionReward> Rewards { get; private set; }

        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        [JsonProperty]
        public float Health { get; private set; }

        [JsonProperty]
        public string AffiliatedWith { get; private set; }

        [JsonProperty("jobs")]
        public List<Bounty> Bounties { get; private set; }
    }
}
