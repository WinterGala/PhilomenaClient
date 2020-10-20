using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class ImagesPage
    {
        [JsonProperty("images")]
        public ImageData[] Images;
        [JsonProperty("interactions")]
        public Interaction[] Interactions;
        [JsonProperty("total")]
        public uint Total;
    }
}
