﻿using Newtonsoft.Json;

using System;

using WorldState.Data.Interfaces;

namespace WorldState.Data.Models
{
    public class SyndicateMission : ITimeSensitive
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public string Syndicate { get; private set; }

        [JsonProperty]
        public string[] Nodes { get; private set; }

        [JsonProperty("jobs")]
        public Bounty[] Bounties { get; private set; }
    }
}
