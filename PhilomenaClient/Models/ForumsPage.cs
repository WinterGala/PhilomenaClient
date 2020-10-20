using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class ForumsPage
    {
        [JsonProperty("forums")]
        public ForumResponse[] Forums;
        [JsonProperty("total")]
        public uint Total;
    }
}
