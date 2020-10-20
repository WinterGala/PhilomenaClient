using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class AwardsResponse
    {
        /// <summary>
        /// The URL of this award.
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl;
        /// <summary>
        /// The title of this award.
        /// </summary>
        [JsonProperty("title")]
        public string Title;
        /// <summary>
        /// The ID of the badge this award is derived from.
        /// </summary>
        [JsonProperty("id")]
        public uint Id;
        /// <summary>
        /// The label of this award.
        /// </summary>
        [JsonProperty("label")]
        public string Label;
        /// <summary>
        /// The time, in UTC, when this award was given.
        /// </summary>
        [JsonProperty("awarded_on")]
        public DateTime AwardedOn;
    }
}
