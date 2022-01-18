using System;

namespace SpaceX.Launch.Plan.Web.Models.Launches
{
    /// <summary>
    /// Represents a launch list item view model.
    /// </summary>
    public class LaunchListItemViewModel
    {
        /// <summary>
        /// ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Date/time UTC
        /// </summary>
        public DateTime DateUtc { get; set; }

        /// <summary>
        /// Flag indicating whether the launch is upcoming or not
        /// </summary>
        public bool Upcoming { get; set; }
    }
}
