using Newtonsoft.Json;

namespace SpaceX.Launch.Plan.Web.Infrastructure
{
    /// <summary>
    /// Represents cores.
    /// </summary>
    public class Cores
    {
        /// <summary>
        /// Gets or sets the core.
        /// </summary>
        [JsonProperty("core")]
        public object? Core { get; set; }

        /// <summary>
        /// Gets or sets the flight.
        /// </summary>
        [JsonProperty("flight")]
        public object? Flight { get; set; }

        /// <summary>
        /// Gets or sets the gridfins.
        /// </summary>
        [JsonProperty("gridfins")]
        public bool? Gridfins { get; set; }

        /// <summary>
        /// Gets or sets the flag indicating whether cores have legs or not.
        /// </summary>
        [JsonProperty("legs")]
        public bool? Legs { get; set; }

        /// <summary>
        /// Gets or sets the flag indicating whether cores are reused or not.
        /// </summary>
        [JsonProperty("reused")]
        public bool? Reused { get; set; }

        /// <summary>
        /// Gets or sets the flag indicating whether cores have lending attempt or not.
        /// </summary>
        [JsonProperty("landing_attempt")]
        public bool? LandingAttempt { get; set; }

        /// <summary>
        /// Gets or sets the landing success.
        /// </summary>
        [JsonProperty("landing_success")]
        public object? LandingSuccess { get; set; }

        /// <summary>
        /// Gets or sets the landing type.
        /// </summary>
        [JsonProperty("landing_type")]
        public object? LandingType { get; set; }

        /// <summary>
        /// Gets or sets the landpad.
        /// </summary>
        [JsonProperty("landpad")]
        public object? Landpad { get; set; }
    }
}
