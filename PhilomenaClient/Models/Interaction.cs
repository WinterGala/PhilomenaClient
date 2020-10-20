using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class Interaction
    {
        [JsonProperty("image_id")]
        public uint ImageId;
        [JsonProperty("interaction_type")]
        public string InteractionType;
        [JsonProperty("user_id")]
        public uint UserId;
        [JsonProperty("value")]
        public string Value;
    }
}
