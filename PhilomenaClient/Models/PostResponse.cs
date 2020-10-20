using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class PostResponse
    {
        /// <summary>
        /// The post's author.
        /// </summary>
        [JsonProperty("author")]
        public string Author;
        /// <summary>
        /// The URL of the author's avatar. May be a link to the CDN path, or a data: URI.
        /// </summary>
        [JsonProperty("avatar")]
        public string Avatar;
        /// <summary>
        /// The post text.
        /// </summary>
        [JsonProperty("body")]
        public string Body;
        /// <summary>
        /// The creation time, in UTC, of the post.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt;
        /// <summary>
        /// The edit reason for this post.
        /// </summary>
        [JsonProperty("edit_reason")]
        public string EditReason;
        /// <summary>
        /// The time, in UTC, this post was last edited at, or null if it was not edited.
        /// </summary>
        [JsonProperty("edited_at")]
        public DateTime? EditedAt;
        /// <summary>
        /// The post's ID (used to identify it).
        /// </summary>
        [JsonProperty("id")]
        public uint Id;
        /// <summary>
        /// The time, in UTC, the post was last updated at.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt;
        /// <summary>
        /// The ID of the user the post belongs to, if any.
        /// </summary>
        [JsonProperty("user_id")]
        public uint? UserId;
    }
}
