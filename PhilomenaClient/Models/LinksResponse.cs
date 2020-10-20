using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class LinksResponse
    {
        /// <summary>
        /// The ID of the user who owns this link.
        /// </summary>
        [JsonProperty("user_id")]
        public uint UserId;
        /// <summary>
        /// The creation time, in UTC, of this link.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt;
        /// <summary>
        /// The state of this link.
        /// </summary>
        [JsonProperty("state")]
        public string State;
        /// <summary>
        /// The ID of an associated tag for this link. null if no tag linked.
        /// </summary>
        [JsonProperty("tag_id")]
        public uint? TagId;
    }
}
