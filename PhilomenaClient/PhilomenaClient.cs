using Philomena.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;
using System.Linq;
using Newtonsoft.Json;

namespace Philomena
{
    /// <summary>
    /// A class that provided a simple client to interact with websites that use the Philomena framework.
    /// </summary>
    public class PhilomenaClient
    {
        /// <summary>
        /// URL for Derpibooru
        /// </summary>
        public static readonly string DerpibooruUrl = "https://derpibooru.org";

        protected HttpClient client;
        protected HttpClientHandler handler = null;

        /// <summary>
        /// A list of the publicly known system filters.
        /// </summary>
        public enum SystemFilters : uint { LegacyDefault = 37431, Dark = 37429, Default = 100073, Everything = 56027, R34 = 37432, MaximumSpoilers = 37430 }

        /// <summary>
        /// Create a new instance of a Philomena API client.
        /// </summary>
        /// <param name="url">The URL of the host that the client will send requests to.</param>
        /// <param name="apiKey">The API key to be used with all requests of this client.</param>
        /// <param name="handler">Optional HttpHandler to be used by derived classes for extra features.</param>
        public PhilomenaClient(string url, string apiKey, HttpClientHandler handler = null)
        {
            this.client = (handler == null) ? new HttpClient() : new HttpClient(handler);
            this.client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT x.y; Win64; x64; rv:10.0) Gecko/20100101 Firefox/10.0");
            this.client.BaseAddress = new Uri(url);
            this.FilterId = (uint)SystemFilters.Default;
            this.ApiKey = (string.IsNullOrWhiteSpace(apiKey)) ? null : apiKey;
        }

        private async Task<T> GetRequest<T>(string path)
        {
            HttpResponseMessage response = await this.client.GetAsync(path);
            if (!response.IsSuccessStatusCode)
            {
                throw new WebException();
            }

            string json = await response.Content.ReadAsStringAsync();
            JObject obj = JObject.Parse(json);

            Type type = typeof(T);

            if (type == typeof(OembedResponse) || type == typeof(ImageResponse))
            {
                return obj.ToObject<T>();
            }
            
            return obj.First.Children().First().ToObject<T>();
        }

        private async Task<T> GetPageRequest<T>(string path)
        {
            HttpResponseMessage response = await this.client.GetAsync(path);
            if (!response.IsSuccessStatusCode)
            {
                throw new WebException();
            }

            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(json);
        }

        #region GetRequests
        /// <summary>
        /// Fetches a comment response for the comment ID referenced by the comment_id URL parameter.
        /// </summary>
        /// <param name="commentId"></param>
        /// <returns>The CommentResponse for the given ID.</returns>
        public async Task<CommentResponse> GetCommentResponse(uint commentId)
        {
            string path = $"/api/v1/json/comments/{commentId}";

            return await this.GetRequest<CommentResponse>(path);
        }

        /// <summary>
        /// Fetches an image response for the image ID referenced by the image_id URL parameter.
        /// </summary>
        /// <param name="imageId">ID of the image to retrieve.</param>
        /// <returns>The ImageResponse for the given ID.</returns>
        public async Task<ImageResponse> GetImageResponse(uint imageId)
        {
            string path = $"/api/v1/json/images/{imageId}?filter_id={this.FilterId}";

            if (this.ApiKey != null)
                path += $"&key={this.ApiKey}";

            return await this.GetRequest<ImageResponse>(path);
        }

        /// <summary>
        /// Fetches an image response for the for the current featured image.
        /// </summary>
        /// <returns>The ImageResponse for the current featured Image.</returns>
        public async Task<ImageResponse> GetFeaturedImageResponse()
        {
            string path = $"/api/v1/json/images/featured";

            return await this.GetRequest<ImageResponse>(path);
        }

        /// <summary>
        /// Fetches a tag response for the tag slug given by the tag_id URL parameter. The tag's ID is not used.
        /// </summary>
        /// <param name="tagId">The tag slug of the tag to find.</param>
        /// <returns>The TagResponse for the given tag slug.</returns>
        public async Task<TagResponse> GetTagResponse(string tagId)
        {
            string path = $"/api/v1/json/tags/{tagId}";

            return await this.GetRequest<TagResponse>(path);
        }

        /// <summary>
        /// Fetches a post response for the post ID given by the post_id URL parameter.
        /// </summary>
        /// <param name="postId">ID of the post to retrieve.</param>
        /// <returns>The PostResponse for the given ID.</returns>
        public async Task<PostResponse> GetPostResponse(uint postId)
        {
            string path = $"/api/v1/json/posts/{postId}";

            return await this.GetRequest<PostResponse>(path);
        }

        /// <summary>
        /// Fetches a profile response for the user ID given by the user_id URL parameter.
        /// </summary>
        /// <param name="userId">ID of the user profile to retrieve.</param>
        /// <returns>The ProfileResponse for the given ID.</returns>
        public async Task<UserResponse> GetProfileResponse(uint userId)
        {
            string path = $"/api/v1/json/profiles/{userId}";

            return await this.GetRequest<UserResponse>(path);
        }

        /// <summary>
        /// Fetches a filter response for the filter ID given by the filter_id URL parameter.
        /// </summary>
        /// <param name="filterId">ID of the filter to retrieve.</param>
        /// <returns>The FilterResponse for the given ID.</returns>
        public async Task<FilterResponse> GetFilterResponse(uint filterId)
        {
            string path = $"/api/v1/json/filters/{filterId}";

            if (this.ApiKey != null)
                path += $"?key={this.ApiKey}";

            return await this.GetRequest<FilterResponse>(path);
        }

        /// <summary>
        /// Fetches a list of filter responses that are flagged as being system filters (and thus usable by anyone).
        /// </summary>
        /// <param name="page">Controls the current page of the response, if the response is paginated. Empty values default to the first page.</param>
        /// <returns>A page of FilterResponses maintained by the website.</returns>
        public async Task<FiltersPage> GetSystemFiltersResponse(uint page = 1)
        {
            string path = $"/api/v1/json/filters/system?page={page}";

            return await this.GetPageRequest<FiltersPage>(path);
        }

        /// <summary>
        /// Fetches a list of filter responses that belong to the user given by key.
        /// </summary>
        /// <param name="page">Controls the current page of the response, if the response is paginated. Empty values default to the first page.</param>
        /// <returns>A page of FilterResponses maintained by the user of the current API key.</returns>
        public async Task<FiltersPage> GetUserFiltersResponse(uint page = 1)
        {
            //Fast fail if an API key wasn't used
            if (this.ApiKey == null)
                throw new InvalidOperationException("This method cannot be called if the client was created without an API key provided.");

            string path = $"/api/v1/json/filters/user?page={page}&key={this.ApiKey}";

            return await this.GetPageRequest<FiltersPage>(path);
        }

        //I honestly don't know what this is for, but it has at least has a slight chance of working how it's intended
        /// <summary>
        /// Fetches an oEmbed response for the given app link or CDN URL.
        /// </summary>
        /// <param name="url">URL to retrieve an oEmbed object of.</param>
        /// <returns>The oEmbedResponse of the given URL.</returns>
        public async Task<OembedResponse> GetOembedResponse(string url)
        {
            string path = $"/api/v1/json/oembed?url={url}";

            return await this.GetRequest<OembedResponse>(path);
        }

        /// <summary>
        /// Executes the search given by the q query parameter, and returns comment responses sorted by descending creation time.
        /// </summary>
        /// <param name="query">The current search query, if the request is a search request.</param>
        /// <param name="page">Controls the current page of the response, if the response is paginated. Empty values default to the first page.</param>
        /// <returns>A page of CommentReponses for the given query.</returns>
        public async Task<CommentsPage> GetCommentSearchResponses(string query, uint page = 1)
        {
            string path = $"/api/v1/json/search/comments?q={query}&page={page}";

            if (this.ApiKey != null)
                path += $"&key={this.ApiKey}";

            return await this.GetPageRequest<CommentsPage>(path);
        }

        /// <summary>
        /// Executes the search given by the q query parameter, and returns gallery responses sorted by descending creation time.
        /// </summary>
        /// <param name="query">The current search query, if the request is a search request.</param>
        /// <param name="page">Controls the current page of the response, if the response is paginated. Empty values default to the first page.</param>
        /// <returns>A page of GalleryResponses for the given query.</returns>
        public async Task<GalleriesPage> GetGallerySearchResponses(string query, uint page = 1)
        {
            string path = $"/api/v1/json/search/galleries?q={query}&page={page}";

            if (this.ApiKey != null)
                path += $"&key={this.ApiKey}";

            return await this.GetPageRequest<GalleriesPage>(path);
        }

        /// <summary>
        /// Executes the search given by the q query parameter, and returns post responses sorted by descending creation time.
        /// </summary>
        /// <param name="query">The current search query, if the request is a search request.</param>
        /// <param name="page">Controls the current page of the response, if the response is paginated. Empty values default to the first page.</param>
        /// <returns>A page of PostResponses for the given query.</returns>
        public async Task<PostsPage> GetPostSearchResponses(string query, uint page = 1)
        {
            string path = $"/api/v1/json/search/posts?q={query}&page={page}";
            
            if (this.ApiKey != null)
                path += $"&key={this.ApiKey}";

            return await this.GetPageRequest<PostsPage>(path);
        }

        /// <summary>
        /// Executes the search given by the q query parameter, and returns image responses.
        /// </summary>
        /// <param name="query">The current search query, if the request is a search request.</param>
        /// <param name="page">Controls the current page of the response, if the response is paginated. Empty values default to the first page.</param>
        /// <param name="perPage">Controls the number of results per page, up to a limit of 50, if the response is paginated. The default is 25.</param>
        /// <param name="sortDirection">The current sort direction, if the request is a search request.</param>
        /// <param name="sortField">The current sort field, if the request is a search request.</param>
        /// <returns>A page of ImageResponses and Interations for the given query.</returns>
        public async Task<ImagesPage> GetImageSearchResponses(string query, uint page = 1, uint perPage = 25, string sortDirection = null, string sortField = null)
        {
            string path = $"/api/v1/json/search/images?q={query}&filter_id={this.FilterId}&page={page}&per_page={perPage}";

            if (sortDirection != null)
                path += $"&sd={sortDirection}";
            if (sortField != null)
                path += $"&sf={sortField}";
            if (this.ApiKey != null)
                path += $"&key={this.ApiKey}";

            return await this.GetPageRequest<ImagesPage>(path);
        }

        /// <summary>
        /// Executes the search given by the q query parameter, and returns tag responses sorted by descending image count.
        /// </summary>
        /// <param name="query">The current search query, if the request is a search request.</param>
        /// <param name="page">Controls the current page of the response, if the response is paginated. Empty values default to the first page.</param>
        /// <returns>A page of TagResponses for the given query.</returns>
        public async Task<TagsPage> GetTagSearchResponses(string query, uint page = 1)
        {
            string path = $"/api/v1/json/search/tags?q={query}&page={page}";

            return await this.GetPageRequest<TagsPage>(path);
        }

        /// <summary>
        /// Returns image responses based on the results of reverse-searching the image given by the url query parameter.
        /// </summary>
        /// <param name="url">URL of an image to search the website for.</param>
        /// <returns>A page of ImageResponses and Interations.</returns>
        public async Task<ImagesPage> GetReverseSearchResponse(string url, float distance)
        {
            string path = $"/api/v1/json/search/reverse?url={url}&distance={distance}";

            if (this.ApiKey != null)
                path += $"&key={this.ApiKey}";

            HttpResponseMessage res = await this.client.PostAsync(path, null);
            if (!res.IsSuccessStatusCode)
                throw new Exception();

            string content = await res.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ImagesPage>(content);
        }

        /// <summary>
        /// Fetches a list of forum responses.
        /// </summary>
        /// <returns>A page of ForumResponses.</returns>
        public async Task<ForumsPage> GetForumResponses()
        {
            string path = $"/api/v1/json/forums";

            return await this.GetPageRequest<ForumsPage>(path);
        }

        /// <summary>
        /// Fetches a forum response for the abbreviated name given by the short_name URL parameter.
        /// </summary>
        /// <param name="shortName">Abbreviated name of the forum to fetch.</param>
        /// <returns>A forum Response for the given short name.</returns>
        public async Task<ForumResponse> GetForumResponse(string shortName)
        {
            string path = $"/api/v1/json/forums/{shortName}";

            return await this.GetRequest<ForumResponse>(path);
        }

        /// <summary>
        /// Fetches a list of topic responses for the abbreviated forum name given by the short_name URL parameter.
        /// </summary>
        /// <param name="shortName">Abbreviated name of the forum to search.</param>
        /// <param name="page">Controls the current page of the response, if the response is paginated. Empty values default to the first page.</param>
        /// <returns>A page of TopicResponses for the provided forum short name.</returns>
        public async Task<TopicsPage> GetTopicResponses(string shortName, uint page = 1)
        {
            string path = $"/api/v1/json/forums/{shortName}/topics?page={page}";

            return await this.GetPageRequest<TopicsPage>(path);
        }

        /// <summary>
        /// Fetches a topic response for the abbreviated forum name given by the short_name and topic given by topic_slug URL parameters.
        /// </summary>
        /// <param name="shortName">Abbreviated name of the forum to search.</param>
        /// <param name="topicSlug">Identifier of the topic to retrieve.</param>
        /// <returns>The TopicResponse for the given topic and forum short names.</returns>
        public async Task<TopicResponse> GetTopicResponse(string shortName, string topicSlug)
        {
            string path = $"/api/v1/json/forums/{shortName}/topics/{topicSlug}";

            return await this.GetRequest<TopicResponse>(path);
        }

        /// <summary>
        /// Fetches a list of post responses for the abbreviated forum name given by the short_name and topic given by topic_slug URL parameters.
        /// </summary>
        /// <param name="shortName">Abbreviated name of the forum to search.</param>
        /// <param name="topicSlug">Identifier of the topic to retrieve.</param>
        /// <param name="page">Controls the current page of the response, if the response is paginated. Empty values default to the first page.</param>
        /// <returns>A page of PostResponses for the given topic and forum short names.</returns>
        public async Task<PostsPage> GetPostResponses(string shortName, string topicSlug, uint page = 1)
        {
            string path = $"/api/v1/json/forums/{shortName}/topics/{topicSlug}/posts?page={page}";

            return await this.GetPageRequest<PostsPage>(path);
        }

        /// <summary>
        /// Fetches a post response for the abbreviated forum name given by the short_name, topic given by topic_slug and post given by post_id URL parameters.
        /// </summary>
        /// <param name="shortName">Abbreviated name of the forum to Search.</param>
        /// <param name="topicSlug">Identifier of the topic to search.</param>
        /// <param name="postId">ID of the post to retrieve.</param>
        /// <returns>The PostResponse for the given topic and forum short names with the specified post id.</returns>
        public async Task<PostResponse> GetPostResponse(string shortName, string topicSlug, uint postId)
        {
            string path = $"/api/v1/json/forums/{shortName}/topics/{topicSlug}/posts/{postId}";

            return await this.GetRequest<PostResponse>(path);
        }
        #endregion

        /// <summary>
        /// The API key that the client will use when making requests.
        /// </summary>
        public string ApiKey { private set; get; }
        /// <summary>
        /// The filter ID that the client will use when making requests.
        /// </summary>
        public uint FilterId { set; get; }
    }
}
