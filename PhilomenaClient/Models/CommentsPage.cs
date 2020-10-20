using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Philomena.Models
{
    public class CommentsPage
    {
        [JsonProperty("comments")]
        CommentResponse[] Comments;
        [JsonProperty("total")]
        uint Total;
    }
}
