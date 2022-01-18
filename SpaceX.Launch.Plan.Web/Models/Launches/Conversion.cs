using SpaceX.Launch.Plan.Web.Controllers;
using System;
using INFRASTRUCTURE = SpaceX.Launch.Plan.Web.Infrastructure;

namespace SpaceX.Launch.Plan.Web.Models.Launches
{
    /// <summary>
	/// Contains methods for converting from and to <see cref="LaunchesController"/> models.
	/// </summary>
    public static class Conversion
    {
        /// <summary>
        /// Converts a <see cref="INFRASTRUCTURE.Launch"/> infrastructure model to a <see cref="LaunchListItemViewModel"/>
        /// API model.
        /// </summary>
        /// <returns>the launche list item model</returns>
        public static LaunchListItemViewModel ConvertLaunchListItem(INFRASTRUCTURE.Launch source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var target = new LaunchListItemViewModel
            {
                Id = source.Id,
                Name = source.Name,
                DateUtc = source.DateUtc,
            };

            return target;
        }
    }
}
