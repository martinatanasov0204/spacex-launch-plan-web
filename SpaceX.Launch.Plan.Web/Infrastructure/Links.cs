using Newtonsoft.Json;

namespace SpaceX.Launch.Plan.Web.Infrastructure
{
    /// <summary>
    /// Represents links.
    /// </summary>
    public class Links
    {
        /// <summary>
        /// Gets or sets the YouTube ID.
        /// </summary>
        [JsonProperty("youtube_id")]
        public object? YouTubeId { get; set; }

        /// <summary>
        /// Gets or sets the article.
        /// </summary>
        [JsonProperty("article")]
        public object? Article { get; set; }

        /// <summary>
        /// Gets or sets the core.
        /// </summary>
        [JsonProperty("core")]
        public object? Core { get; set; }

        /// <summary>
        /// Gets or sets the patch.
        /// </summary>
        [JsonProperty("patch")]
        public Patch Patch { get; set; }

        /// <summary>
        /// Gets or sets the reddit.
        /// </summary>
        [JsonProperty("reddit")]
        public Reddit Reddit { get; set; }

        /// <summary>
        /// Gets or sets the flickr.
        /// </summary>
        [JsonProperty("flickr")]
        public Flickr Flickr { get; set; }

        /// <summary>
        /// Gets or sets the presskit.
        /// </summary>
        [JsonProperty("presskit")]
        public object? Presskit { get; set; }

        /// <summary>
        /// Gets or sets the webcast.
        /// </summary>
        [JsonProperty("webcast")]
        public object? Webcast { get; set; }

        /// <summary>
        /// Gets or sets the Wikipedia.
        /// </summary>
        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }
    }
}
