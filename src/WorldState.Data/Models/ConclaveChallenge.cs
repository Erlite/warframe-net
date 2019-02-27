﻿using System;

using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class ConclaveChallenge
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty]
        public string Description { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public int Amount { get; private set; }

        [JsonProperty]
        public string Mode { get; private set; }

        // Todo: Duplicate (string representation) of Daily? Remove.
        [JsonProperty]
        public string Category { get; private set; }

        [JsonProperty]
        public bool Expired { get; private set; }

        [JsonProperty]
        public bool Daily { get; private set; }

        [JsonProperty]
        public bool RootChallenge { get; private set; }

        public override String ToString()
        {
            return $"{Description} on {Mode} {Amount} {(Amount > 1 ? "times" : "time")} " +
                   $"in a {(Daily ? "day" : "week")}.";
        }
    }
}
