using Newtonsoft.Json;
using System.Collections.Generic;

namespace SpaceX.Launch.Plan.Web.Infrastructure
{
    /// <summary>
    /// Represents fairings.
    /// </summary>
    public class Fairings
    {
        /// <summary>
        /// Gets or sets the reused fairings.
        /// </summary>
        [JsonProperty("reused")]
        public object? Reused { get; set; }

        /// <summary>
        /// Gets or sets the recovery attempt.
        /// </summary>
        [JsonProperty("recovery_attempt")]
        public object? RecoveryAttempt { get; set; }

        /// <summary>
        /// Gets or sets the recovered fairings.
        /// </summary>
        [JsonProperty("recovered")]
        public object? Recovered { get; set; }

        /// <summary>
        /// Gets or sets the ships.
        /// </summary>
        [JsonProperty("ships")]
        public List<object> Ships { get; set; }
    }
}
