using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class FiltersPage
    {
        [JsonProperty("filters")]
        FilterResponse[] Filters;
        [JsonProperty("total")]
        uint TotalResults;
    }
}
