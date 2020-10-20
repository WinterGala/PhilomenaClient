using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class GalleryResponse
    {
        /// <summary>
        /// The gallery's description.
        /// </summary>
        [JsonProperty("description")]
        public string Description;
        /// <summary>
        /// The gallery's ID.
        /// </summary>
        [JsonProperty("id")]
        public uint Id;
        /// <summary>
        /// The gallery's spoiler warning.
        /// </summary>
        [JsonProperty("spoiler_warning")]
        public string SpoilerWarning;
        /// <summary>
        /// The ID of the cover image for the gallery.
        /// </summary>
        [JsonProperty("thumbnail_id")]
        public uint ThumbnailId;
        /// <summary>
        /// The gallery's title.
        /// </summary>
        [JsonProperty("title")]
        public string Title;
        /// <summary>
        /// The name of the gallery's creator.
        /// </summary>
        [JsonProperty("user")]
        public string User;
        /// <summary>
        /// The ID of the gallery's creator.
        /// </summary>
        [JsonProperty("user_id")]
        public uint UserId;
    }
}
