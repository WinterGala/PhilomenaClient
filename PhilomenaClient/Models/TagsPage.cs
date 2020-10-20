using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class TagsPage
    {
        [JsonProperty("tags")]
        public TagResponse[] Tags;
        [JsonProperty("total")]
        public uint Total;
    }
}
