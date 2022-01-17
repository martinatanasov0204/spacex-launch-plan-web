using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace SpaceX.Launch.Plan.Web
{
    /// <summary>
	/// Represents the application.
	/// </summary>
    public class Program
    {
        /// <summary>
		/// Provides the main entrypoint of the application.
		/// </summary>
		/// <param name="args">the application arguments</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args)
                .Build()
                .Run();
        }

        /// <summary>
		/// Builds the web host.
		/// </summary>
		/// <param name="args">the application arguments</param>
        public static IHostBuilder CreateHostBuilder(string[] args) 
            => Host
                .CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
