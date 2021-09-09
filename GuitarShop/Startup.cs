﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GuitarShop
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // allows us to bind Controller with views
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints => {

            // most specific route – 5 required segments 
            endpoints.MapControllerRoute(
            name: "paging_and_sorting",
            pattern: "{controller}/{action}/{id}/page{page}/sort-by-{sortby}");

            // specific route – 4 required segments
            endpoints.MapControllerRoute(
            name: "paging",
            pattern: "{controller}/{action}/{id}/page{page}");

             // least specific route – 0 required segments
            endpoints.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}