using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class ImageResponse
    {
        [JsonProperty("image")]
        public ImageData Image;
        [JsonProperty("interactions")]
        public Interaction[] Interactions;
    }
}
