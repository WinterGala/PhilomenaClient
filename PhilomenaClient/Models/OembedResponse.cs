using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class OembedResponse
    {
        /// <summary>
        /// The comma-delimited names of the image authors.
        /// </summary>
        [JsonProperty("author_name")]
        public string AuthorName;
        /// <summary>
        /// The source URL of the image.
        /// </summary>
        [JsonProperty("author_url")]
        public string AuthorUrl;
        /// <summary>
        /// Always 7200.
        /// </summary>
        [JsonProperty("cache_age")]
        public uint CacheAge;
        /// <summary>
        /// The number of comments made on the image.
        /// </summary>
        [JsonProperty("derpibooru_comments")]
        public uint DerpibooruComments;
        /// <summary>
        /// The image's ID.
        /// </summary>
        [JsonProperty("derpibooru_id")]
        public uint DerpibooruId;
        /// <summary>
        /// The image's number of upvotes minus the image's number of downvotes.
        /// </summary>
        [JsonProperty("derpibooru_score")]
        public uint DerpibooruScore;
        /// <summary>
        /// The names of the image's tags.
        /// </summary>
        [JsonProperty("derpibooru_tags")]
        public string[] DerpibooruTags;
        /// <summary>
        /// Always "Derpibooru".
        /// </summary>
        [JsonProperty("provider_name")]
        public string ProviderName;
        /// <summary>
        /// Always "https://derpibooru.org".
        /// </summary>
        [JsonProperty("provider_url")]
        public string ProviderUrl;
        /// <summary>
        /// The image's ID and associated tags, as would be given on the title of the image page.
        /// </summary>
        [JsonProperty("title")]
        public string Title;
        /// <summary>
        /// Always "photo".
        /// </summary>
        [JsonProperty("type")]
        public string Type;
        /// <summary>
        /// Always "1.0".
        /// </summary>
        [JsonProperty("version")]
        public string Version;
    }
}
