using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SpaceX.Launch.Plan.Web.Infrastructure;

namespace SpaceX.Launch.Plan.Web
{
    /// <summary>
	/// Represents the startup class of the application.
	/// </summary>
    public class Startup
    {
        private readonly IConfiguration _configuration;

        /// <summary>
		/// Initializes a new instance of the <see cref="Startup"/> class.
		/// </summary>
		/// <param name="configuration">the configuration</param>
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
		/// Adds services to the container.
		/// </summary>
		/// <param name="services">the service collection</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<SpaceXEndpointsOptions>(options =>
            {
                _configuration.GetSection("SpaceXEndpointsOptions").Bind(options);
            });

            services.AddControllersWithViews();
        }

        /// <summary>
		/// Configures the HTTP request pipeline.
		/// </summary>
		/// <param name="app">the application builder</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/årror");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
