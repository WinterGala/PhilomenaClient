using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class ForumResponse
    {
        /// <summary>
        ///  The forum's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;
        /// <summary>
        /// The forum's short name (used to identify it).
        /// </summary>
        [JsonProperty("short_name")]
        public string ShortName;
        /// <summary>
        /// The forum's description.
        /// </summary>
        [JsonProperty("description")]
        public string Description;
        /// <summary>
        /// The amount of topics in the forum.
        /// </summary>
        [JsonProperty("topic_count")]
        public uint TopicCount;
        /// <summary>
        /// The amount of posts in the forum.
        /// </summary>
        [JsonProperty("post_count")]
        public uint PostCount;
    }
}
