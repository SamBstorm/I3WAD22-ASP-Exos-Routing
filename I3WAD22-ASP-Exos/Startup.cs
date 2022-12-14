using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace I3WAD22_ASP_Exos
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                //endpoints.MapControllerRoute(
                //    name:"MathCarre",
                //    pattern:"Math/{id}/auCarre",
                //    defaults : new { Controller = "Math", Action = "Carre"}
                //    );

                endpoints.MapControllerRoute(
                    name: "Contrat",
                    pattern: "Contrat-de-confidentialite",
                    defaults : new { Controller = "Home", Action = "Privacy"}
                    );

                endpoints.MapControllerRoute(
                    name: "Action",
                    pattern: "{action}",
                    defaults: new { Controller = "Home"}
                    );

                endpoints.MapControllerRoute(
                    name: "Monsite",
                    pattern: "Monsite/{action=Index}",
                    defaults: new { Controller = "Home"}
                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
