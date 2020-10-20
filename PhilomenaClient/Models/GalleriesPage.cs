using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class GalleriesPage
    {
        [JsonProperty("galleries")]
        public GalleryResponse[] Galleries;
        [JsonProperty("total")]
        public uint Total;
    }
}
