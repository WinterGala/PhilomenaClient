using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class FilterResponse
    {
        /// <summary>
        /// The id of the filter.
        /// </summary>
        [JsonProperty("id")]
        public uint Id;
        /// <summary>
        /// The name of the filter.
        /// </summary>
        [JsonProperty("name")]
        public string Name;
        /// <summary>
        /// The description of the filter.
        /// </summary>
        [JsonProperty("description")]
        public string Description;
        /// <summary>
        /// The id of the user the filter belongs to. null if it isn't assigned to a user (usually system filters only).
        /// </summary>
        [JsonProperty("user_id")]
        public uint? UserId;
        /// <summary>
        /// The amount of users employing this filter.
        /// </summary>
        [JsonProperty("user_count")]
        public uint UserCount;
        /// <summary>
        /// If true, is a system filter. System filters are usable by anyone and don't have a user_id set.
        /// </summary>
        [JsonProperty("system")]
        public bool IsSystem;
        /// <summary>
        /// If true, is a public filter. Public filters are usable by anyone.
        /// </summary>
        [JsonProperty("public")]
        public bool isPublic;
        /// <summary>
        /// A list of tag IDs (as integers) that this filter will spoil.
        /// </summary>
        [JsonProperty("spoilered_tag_ids")]
        public uint[] SpoileredTagIds;
        /// <summary>
        /// The complex spoiled filter.
        /// </summary>
        [JsonProperty("spoilered_complex")]
        public string SpoileredComplex;
        /// <summary>
        /// A list of tag IDs (as integers) that this filter will hide.
        /// </summary>
        [JsonProperty("hidden_tag_ids")]
        public uint[] HiddenTagIds;
        /// <summary>
        /// The complex hidden filter.
        /// </summary>
        [JsonProperty("hidden_complex")]
        public string HiddenComplex;
    }
}
