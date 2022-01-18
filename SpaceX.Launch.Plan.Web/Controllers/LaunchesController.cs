using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using SpaceX.Launch.Plan.Web.Models.Launches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using INFRASTRUCTURE = SpaceX.Launch.Plan.Web.Infrastructure;

namespace SpaceX.Launch.Plan.Web.Controllers
{
    /// <summary>
    /// Provides access to launches.
    /// </summary>
    [ApiController]
    [Route("launches")]
    public class LaunchesController : Controller
    {
        private readonly INFRASTRUCTURE.SpaceXEndpointsOptions _spaceXEndpointsOptions;

        /// <summary>
		/// Initializes a new instance of the <see cref="LaunchesController"/> class.
		/// </summary>
        /// <param name="spaceXEndpointsOptions">the SpaceX endpoints options</param>
        public LaunchesController(
            IOptions<INFRASTRUCTURE.SpaceXEndpointsOptions> spaceXEndpointsOptions)
        {
            _spaceXEndpointsOptions = spaceXEndpointsOptions.Value ?? throw new ArgumentNullException(nameof(spaceXEndpointsOptions));
        }

        #region Actions

        /// <summary>
        /// Shows the launches page.
        /// </summary>
        /// <returns>the launches page</returns>
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Launches()
        {
            var launches = new List<INFRASTRUCTURE.Launch>();

            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync(_spaceXEndpointsOptions.Upcoming);

                string responseContent = await response.Content.ReadAsStringAsync();

                launches = JsonConvert.DeserializeObject<List<INFRASTRUCTURE.Launch>>(responseContent);
            }

            LaunchListItemViewModel[]? launcheListItemViewModels = launches?
                .Select(Conversion.ConvertLaunchListItem)
                .ToArray();

            return View(launcheListItemViewModels);
        }

        #endregion
    }
}
