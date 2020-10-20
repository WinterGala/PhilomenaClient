using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class PostsPage
    {
        [JsonProperty("posts")]
        public PostResponse[] Posts;
        [JsonProperty("total")]
        public uint Total;
    }
}
