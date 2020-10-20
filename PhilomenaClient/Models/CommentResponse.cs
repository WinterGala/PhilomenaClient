using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Philomena.Models
{
    public class CommentResponse
    {
        /// <summary>
        /// The comment's author.
        /// </summary>
        [JsonProperty("author")]
        public string Author;
        /// <summary>
        /// The URL of the author's avatar. May be a link to the CDN path, or a data: URI.
        /// </summary>
        [JsonProperty("avatar")]
        public string Avatar;
        /// <summary>
        /// The comment text.
        /// </summary>
        [JsonProperty("body")]
        public string Body;
        /// <summary>
        /// The creation time, in UTC, of the comment.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt;
        /// <summary>
        /// The edit reason for this comment, or null if none provided.
        /// </summary>
        [JsonProperty("edit_reason")]
        public string EditReason;
        /// <summary>
        /// The time, in UTC, this comment was last edited at, or null if it was not edited.
        /// </summary>
        [JsonProperty("edited_at")]
        public DateTime? EditedAt;
        /// <summary>
        /// The comment's ID.
        /// </summary>
        [JsonProperty("id")]
        public uint Id;
        /// <summary>
        /// The ID of the image the comment belongs to.
        /// </summary>
        [JsonProperty("image_id")]
        public uint ImageId;
        /// <summary>
        /// The time, in UTC, the comment was last updated at.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt;
        /// <summary>
        /// The ID of the user the comment belongs to, if any.
        /// </summary>
        [JsonProperty("user_id")]
        public uint? UserId;
    }
}
