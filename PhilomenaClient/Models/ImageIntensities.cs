using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class ImageIntensities
    {
        [JsonProperty("ne")]
        public float NorthEast;
        [JsonProperty("nw")]
        public float NorthWest;
        [JsonProperty("se")]
        public float SouthEast;
        [JsonProperty("sw")]
        public float SouthWest;
    }
}
