using Newtonsoft.Json;
using System.Collections.Generic;

namespace SpaceX.Launch.Plan.Web.Infrastructure
{
    /// <summary>
    /// Represents a flickr.
    /// </summary>
    public class Flickr
    {
        /// <summary>
        /// Gets or sets the small flickr.
        /// </summary>
        [JsonProperty("small")]
        public List<object> Small { get; set; }

        /// <summary>
        /// Gets or sets the original flickr.
        /// </summary>
        [JsonProperty("original")]
        public List<object> Original { get; set; }
    }
}
