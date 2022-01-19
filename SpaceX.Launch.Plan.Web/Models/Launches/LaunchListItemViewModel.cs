using System;

namespace SpaceX.Launch.Plan.Web.Models.Launches
{
    /// <summary>
    /// Represents a launch list item view model.
    /// </summary>
    public class LaunchListItemViewModel
    {
        /// <summary>
        /// Flight number
        /// </summary>
        public int FlightNumber { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Date/time
        /// </summary>
        public DateTime Date { get; set; }
    }
}
