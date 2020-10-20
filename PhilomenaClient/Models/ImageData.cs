using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class ImageData
    {
        /// <summary>
        /// Whether the image is animated.
        /// </summary>
        [JsonProperty("animated")]
        public bool IsAnimated;
        /// <summary>
        /// The image's width divided by its height.
        /// </summary>
        [JsonProperty("aspect_ratio")]
        public float AspectRatio;
        /// <summary>
        /// The number of comments made on the image.
        /// </summary>
        [JsonProperty("comment_count")]
        public uint CommentCount;
        /// <summary>
        /// The creation time, in UTC, of the image.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt;
        /// <summary>
        /// The hide reason for the image, or null if none provided. This will only have a value on images which are deleted for a rule violation.
        /// </summary>
        [JsonProperty("deletion_reason")]
        public string DeletionReason;
        /// <summary>
        /// The image's description.
        /// </summary>
        [JsonProperty("description")]
        public string Description;
        /// <summary>
        /// The number of downvotes the image has.
        /// </summary>
        [JsonProperty("downvotes")]
        public uint Downvotes;
        /// <summary>
        /// The ID of the target image, or null if none provided. This will only have a value on images which are merged into another image.
        /// </summary>
        [JsonProperty("duplicate_of")]
        public uint? DuplicateOf;
        /// <summary>
        /// The number of seconds the image lasts, if animated, otherwise .04.
        /// </summary>
        [JsonProperty("duration")]
        public float Duration;
        /// <summary>
        /// The number of faves the image has.
        /// </summary>
        [JsonProperty("favorites")]
        public uint Favorites;
        /// <summary>
        /// The time, in UTC, the image was first seen (before any duplicate merging).
        /// </summary>
        [JsonProperty("first_seen_at")]
        public DateTime FirstSeenAt;
        /// <summary>
        /// The file extension of the image. One of "gif", "jpg", "jpeg", "png", "svg", "webm".
        /// </summary>
        [JsonProperty("format")]
        public string Format;
        /// <summary>
        /// The image's height, in pixels.
        /// </summary>
        [JsonProperty("height")]
        public uint Height;
        /// <summary>
        /// Whether the image is hidden. An image is hidden if it is merged or deleted for a rule violation.
        /// </summary>
        [JsonProperty("hidden_from_users")]
        public bool IsHiddenFromUsers;
        /// <summary>
        /// The image's ID.
        /// </summary>
        [JsonProperty("id")]
        public uint Id;
        /// <summary>
        /// Optional object of internal image intensity data for deduplication purposes. May be null if intensities have not yet been generated.
        /// </summary>
        [JsonProperty("intensities")]
        public ImageIntensities Intensities;
        /// <summary>
        /// The MIME type of this image. One of "image/gif", "image/jpeg", "image/png", "image/svg+xml", "video/webm".
        /// </summary>
        [JsonProperty("mime_type")]
        public string MimeType;
        /// <summary>
        /// The filename that the image was uploaded with.
        /// </summary>
        [JsonProperty("name")]
        public string Name;
        /// <summary>
        /// The SHA512 hash of the image as it was originally uploaded.
        /// </summary>
        [JsonProperty("orig_sha512_hash")]
        public string OriginalSha512Hash;
        /// <summary>
        /// Whether the image has finished optimization.
        /// </summary>
        [JsonProperty("processed")]
        public bool IsProcessed;
        /// <summary>
        /// A mapping of representation names to their respective URLs.
        /// </summary>
        [JsonProperty("representations")]
        public ImageRepresentations Representations;
        /// <summary>
        /// The image's number of upvotes minus the image's number of downvotes.
        /// </summary>
        [JsonProperty("score")]
        public int Score;
        /// <summary>
        /// The SHA512 hash of this image after it has been processed.
        /// </summary>
        [JsonProperty("sha512_hash")]
        public string Sha512Hash;
        /// <summary>
        /// The number of bytes the image's file contains.
        /// </summary>
        [JsonProperty("size")]
        public uint Size;
        /// <summary>
        /// The current source URL of the image.
        /// </summary>
        [JsonProperty("source_url")]
        public string SourceUrl;
        /// <summary>
        /// Whether the image is hit by the current filter.
        /// </summary>
        [JsonProperty("spoilered")]
        public bool IsSpoilered;
        /// <summary>
        /// The number of tags present on the image.
        /// </summary>
        [JsonProperty("tag_count")]
        public uint TagCount;
        /// <summary>
        /// A list of tag IDs the image contains.
        /// </summary>
        [JsonProperty("tag_ids")]
        public uint[] TagIds;
        /// <summary>
        /// A list of tag names the image contains.
        /// </summary>
        [JsonProperty("tags")]
        public string[] Tags;
        /// <summary>
        /// Whether the image has finished thumbnail generation. Do not attempt to load images from view_url or representations if this is false.
        /// </summary>
        [JsonProperty("thumbnails_generated")]
        public bool IsThumbnailsGenerated;
        /// <summary>
        /// The time, in UTC, the image was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt;
        /// <summary>
        /// The image's uploader.
        /// </summary>
        [JsonProperty("uploader")]
        public string Uploader;
        /// <summary>
        /// The ID of the image's uploader. null if uploaded anonymously.
        /// </summary>
        [JsonProperty("uploader_id")]
        public uint? UploaderId;
        /// <summary>
        /// The image's number of upvotes.
        /// </summary>
        [JsonProperty("upvotes")]
        public uint Upvotes;
        /// <summary>
        /// The image's view URL, including tags.
        /// </summary>
        [JsonProperty("view_url")]
        public string ViewUrl;
        /// <summary>
        /// The image's width, in pixels.
        /// </summary>
        [JsonProperty("width")]
        public uint Width;
        /// <summary>
        /// The lower bound of the Wilson score interval for the image, based on its upvotes and downvotes, given a z-score corresponding to a confidence of 99.5%.
        /// </summary>
        [JsonProperty("wilson_score")]
        public float WilsonScore;
    }
}
