using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class UserResponse
    {
        /// <summary>
        /// The ID of the user.
        /// </summary>
        [JsonProperty("id")]
        public uint Id;
        /// <summary>
        /// The name of the user.
        /// </summary>
        [JsonProperty("name")]
        public string Name;
        /// <summary>
        /// The slug of the user.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug;
        /// <summary>
        /// The role of the user.
        /// </summary>
        [JsonProperty("role")]
        public string Role;
        /// <summary>
        /// The description (bio) of the user.
        /// </summary>
        [JsonProperty("description")]
        public string Description;
        /// <summary>
        /// The URL of the user's thumbnail. null if the avatar is not set.
        /// </summary>
        [JsonProperty("avatar_url")]
        public string AvatarUrl;
        /// <summary>
        /// The creation time, in UTC, of the user.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt;
        /// <summary>
        /// The comment count of the user.
        /// </summary>
        [JsonProperty("comments_count")]
        public uint CommentsCount;
        /// <summary>
        /// The upload count of the user.
        /// </summary>
        [JsonProperty("uploads_count")]
        public uint UploadsCount;
        /// <summary>
        /// The forum posts count of the user.
        /// </summary>
        [JsonProperty("posts_count")]
        public uint PostsCount;
        /// <summary>
        /// The forum topics count of the user.
        /// </summary>
        [JsonProperty("topics_count")]
        public uint TopicsCount;
        /// <summary>
        /// The links the user has registered. See <see cref="LinksResponse"/>.
        /// </summary>
        [JsonProperty("links")]
        public LinksResponse[] Links;
        /// <summary>
        /// The awards/badges of the user. See <see cref="AwardsResponse"/>.
        /// </summary>
        [JsonProperty("awards")]
        public AwardsResponse[] Awards;
    }
}
