using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class TopicResponse
    {
        /// <summary>
        /// The topic's slug (used to identify it).
        /// </summary>
        [JsonProperty("slug")]
        public string Slug;
        /// <summary>
        /// The topic's title.
        /// </summary>
        [JsonProperty("title")]
        public string Title;
        /// <summary>
        /// The amount of posts in the topic.
        /// </summary>
        [JsonProperty("post_count")]
        public uint PostCount;
        /// <summary>
        /// The amount of views the topic has received.
        /// </summary>
        [JsonProperty("view_count")]
        public uint ViewCount;
        /// <summary>
        /// Whether the topic is sticky.
        /// </summary>
        [JsonProperty("sticky")]
        public bool IsSticky;
        /// <summary>
        /// The time, in UTC, when the last reply was made.
        /// </summary>
        [JsonProperty("last_replied_to_at")]
        public DateTime LastRepliedToAt;
        /// <summary>
        /// Whether the topic is locked.
        /// </summary>
        [JsonProperty("locked")]
        public bool IsLocked;
        /// <summary>
        /// The ID of the user who made the topic. null if posted anonymously.
        /// </summary>
        [JsonProperty("user_id")]
        public uint? UserId;
        /// <summary>
        /// The name of the user who made the topic.
        /// </summary>
        [JsonProperty("author")]
        public string Author;
    }
}
