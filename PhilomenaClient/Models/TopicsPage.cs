using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class TopicsPage
    {
        [JsonProperty("topics")]
        public TopicResponse[] Topics;
        [JsonProperty("total")]
        public uint Total;
    }
}
