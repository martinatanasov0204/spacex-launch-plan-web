using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SpaceX.Launch.Plan.Web.Infrastructure
{
    /// <summary>
    /// Represents a launch.
    /// </summary>
    public class Launch
    {
        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the launch library ID.
        /// </summary>
        [JsonProperty("launch_library_id")]
        public string LaunchLibraryId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the launchpad.
        /// </summary>
        [JsonProperty("launchpad")]
        public string Launchpad { get; set; }

        /// <summary>
        /// Gets or sets the flight number.
        /// </summary>
        [JsonProperty("flight_number")]
        public int FlightNumber { get; set; }

        /// <summary>
        /// Gets or sets the fairings.
        /// </summary>
        [JsonProperty("fairings")]
        public Fairings Fairings { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        [JsonProperty("links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets or sets the static fire date UTC.
        /// </summary>
        [JsonProperty("static_fire_date_utc")]
        public object? StaticFireDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the static fire date unix.
        /// </summary>
        [JsonProperty("static_fire_date_unix")]
        public object? StaticFireDateUnix { get; set; }

        /// <summary>
        /// Gets or sets the flag indicating whether the launch is net or not.
        /// </summary>
        [JsonProperty("net")]
        public bool Net { get; set; }

        /// <summary>
        /// Gets or sets the window.
        /// </summary>
        [JsonProperty("window")]
        public object? Window { get; set; }

        /// <summary>
        /// Gets or sets the rocket.
        /// </summary>
        [JsonProperty("rocket")]
        public string Rocket { get; set; }

        /// <summary>
        /// Gets or sets the flag indicating whether the launch is success or not.
        /// </summary>
        [JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Gets or sets the failures.
        /// </summary>
        [JsonProperty("failures")]
        public List<object> Failures { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        [JsonProperty("details")]
        public object? Details { get; set; }

        /// <summary>
        /// Gets or sets the crew.
        /// </summary>
        [JsonProperty("crew")]
        public List<object> Crew { get; set; }

        /// <summary>
        /// Gets or sets the ships.
        /// </summary>
        [JsonProperty("ships")]
        public List<object> Ships { get; set; }

        /// <summary>
        /// Gets or sets the capsules.
        /// </summary>
        [JsonProperty("capsules")]
        public List<object> Capsules { get; set; }

        /// <summary>
        /// Gets or sets the payloads.
        /// </summary>
        [JsonProperty("payloads")]
        public List<string> Payloads { get; set; }

        /// <summary>
        /// Gets or sets the date/time UTC.
        /// </summary>
        [JsonProperty("date_utc")]
        public DateTime DateUtc { get; set; }

        /// <summary>
        /// Gets or sets the date unix.
        /// </summary>
        [JsonProperty("date_unix")]
        public int DateUnix { get; set; }

        /// <summary>
        /// Gets or sets the date/time local.
        /// </summary>
        [JsonProperty("date_local")]
        public DateTime DateLocal { get; set; }

        /// <summary>
        /// Gets or sets the date precision.
        /// </summary>
        [JsonProperty("date_precision")]
        public string DatePrecision { get; set; }

        /// <summary>
        /// Gets or sets the flag indicating whether the launch is upcoming or not.
        /// </summary>
        [JsonProperty("upcoming")]
        public bool Upcoming { get; set; }

        /// <summary>
        /// Gets or sets the cores.
        /// </summary>
        [JsonProperty("cores")]
        public List<Cores> Cores { get; set; }

        /// <summary>
        /// Gets or sets the flag indicating whether the launch is auto-updated or not.
        /// </summary>
        [JsonProperty("auto_update")]
        public bool AutoUpdate { get; set; }

        /// <summary>
        /// Gets or sets the flag indicating whether the launch is tbd or not.
        /// </summary>
        [JsonProperty("tbd")]
        public bool Tbd { get; set; }
    }
}
