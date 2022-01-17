using Microsoft.AspNetCore.Mvc;
using SpaceX.Launch.Plan.Web.Models;
using System.Diagnostics;

namespace SpaceX.Launch.Plan.Web.Controllers
{
    /// <summary>
	/// Represents a home controller for the SpaceX Launch Plan.
	/// </summary>
    public class HomeController : Controller
    {
        /// <summary>
		/// Initializes a new instance of the <see cref="HomeController"/> class.
		/// </summary>
        public HomeController()
        {
        }

        /// <summary>
		/// Shows the home page.
		/// </summary>
		/// <returns>the home page</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
		/// Shows the error page.
		/// </summary>
		/// <returns>the error page</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var errorViewModel = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
            };

            return View(errorViewModel);
        }
    }
}
