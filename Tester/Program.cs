using System;

using Philomena;
using Philomena.Models;

namespace Tester
{
    class Program
    {
        static void Main()
        {
            PhilomenaClient client = new PhilomenaClient(PhilomenaClient.DerpibooruUrl, null);
            //CommentResponse comment = client.GetCommentResponse(1000).Result;
            //ImageResponse image = client.GetImageResponse(1).Result;
            //TagResponse tag = client.GetTagResponse("artist-colon-atryl").Result;
            //PostResponse post = client.GetPostResponse(2730144).Result;
            //UserResponse user = client.GetProfileResponse(216494).Result;
            //FilterResponse filter = client.GetFilterResponse(56027).Result;
            //FiltersPage filters = client.GetSystemFiltersResponse().Result;
            //CommentsPage comments = client.GetCommentSearchResponses("image_id:1000000").Result;
            //GalleriesPage galleries = client.GetGallerySearchResponses("title:mean*").Result;
            //PostsPage posts = client.GetPostSearchResponses("subject:time wasting thread").Result;
            //ImagesPage images = client.GetImageSearchResponses("safe").Result;
            //TagsPage tags = client.GetTagSearchResponses("analyzed_name:wing").Result;
            //ForumsPage forums = client.GetForumResponses().Result;
            //ForumResponse forum = client.GetForumResponse("dis").Result;
            //TopicsPage topics = client.GetTopicResponses("dis").Result;
            //TopicResponse topic = client.GetTopicResponse("dis", "ask-the-mods-anything").Result;
            //PostsPage posts = client.GetPostResponses("dis", "ask-the-mods-anything").Result;
            //PostResponse post = client.GetPostResponse("dis", "ask-the-mods-anything", 2761095).Result;
            Console.ReadLine();
        }
    }
}
