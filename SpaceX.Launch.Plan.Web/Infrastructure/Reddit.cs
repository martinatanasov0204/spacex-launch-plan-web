using Newtonsoft.Json;

namespace SpaceX.Launch.Plan.Web.Infrastructure
{
    /// <summary>
    /// Represents a reddit.
    /// </summary>
    public class Reddit
    {
        /// <summary>
        /// Gets or sets the campaign.
        /// </summary>
        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        /// <summary>
        /// Gets or sets the launch.
        /// </summary>
        [JsonProperty("launch")]
        public object? Launch { get; set; }

        /// <summary>
        /// Gets or sets the media.
        /// </summary>
        [JsonProperty("media")]
        public object? Media { get; set; }

        /// <summary>
        /// Gets or sets the recovery.
        /// </summary>
        [JsonProperty("recovery")]
        public string Recovery { get; set; }
    }
}
