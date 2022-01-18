using Newtonsoft.Json;

namespace SpaceX.Launch.Plan.Web.Infrastructure
{
    /// <summary>
    /// Represents a patch.
    /// </summary>
    public class Patch
    {
        /// <summary>
        /// Gets or sets the small patch.
        /// </summary>
        [JsonProperty("small")]
        public string Small { get; set; }

        /// <summary>
        /// Gets or sets the large patch.
        /// </summary>
        [JsonProperty("large")]
        public string Large { get; set; }
    }
}
