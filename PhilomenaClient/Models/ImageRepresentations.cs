using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class ImageRepresentations
    {
        [JsonProperty("full")]
        public string Full;
        [JsonProperty("large")]
        public string Large;
        [JsonProperty("medium")]
        public string Medium;
        [JsonProperty("small")]
        public string Small;
        [JsonProperty("tall")]
        public string Tall;
        [JsonProperty("thumb")]
        public string Thumb;
        [JsonProperty("thumb_small")]
        public string ThumbSmall;
        [JsonProperty("thumb_tiny")]
        public string ThumbTiny;
    }
}
