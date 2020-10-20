using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class TagResponse
    {
        /// <summary>
        /// The slug of the tag this tag is aliased to, if any.
        /// </summary>
        [JsonProperty("aliased_tag")]
        public string AliasedTag;
        /// <summary>
        /// The slugs of the tags aliased to this tag.
        /// </summary>
        [JsonProperty("aliases")]
        public string[] Aliases;
        /// <summary>
        /// The category class of this tag. One of "character", "content-fanmade", "content-official", "error", "oc", "origin", "rating", "species", "spoiler".
        /// </summary>
        [JsonProperty("category")]
        public string Category;
        /// <summary>
        /// The long description for the tag.
        /// </summary>
        [JsonProperty("description")]
        public string Description;
        /// <summary>
        /// An array of objects containing DNP entries claimed on the tag.
        /// </summary>
        [JsonProperty("dnp_entries")]
        public string[] DnpEntries;
        /// <summary>
        /// The tag's ID.
        /// </summary>
        [JsonProperty("id")]
        public uint Id;
        /// <summary>
        /// The image count of the tag.
        /// </summary>
        [JsonProperty("images")]
        public uint Images;
        /// <summary>
        /// The slugs of the tags this tag is implied by.
        /// </summary>
        [JsonProperty("implied_by_tags")]
        public string[] ImpliedByTags;
        /// <summary>
        /// The slugs of the tags this tag implies.
        /// </summary>
        [JsonProperty("implied_tags")]
        public string[] ImpliedTags;
        /// <summary>
        /// The name of the tag.
        /// </summary>
        [JsonProperty("name")]
        public string Name;
        /// <summary>
        /// The name of the tag in its namespace.
        /// </summary>
        [JsonProperty("name_in_namespace")]
        public string NameInNamespace;
        /// <summary>
        /// The namespace of the tag.
        /// </summary>
        [JsonProperty("namespace")]
        public string Namespace;
        /// <summary>
        /// The short description for the tag.
        /// </summary>
        [JsonProperty("short_description")]
        public string ShortDescription;
        /// <summary>
        /// The slug for the tag.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug;
        /// <summary>
        /// The spoiler image for the tag.
        /// </summary>
        [JsonProperty("spoiler_image_uri")]
        public string SpoilerImageUri;
    }
}
