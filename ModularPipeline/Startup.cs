using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace ModularPipeline
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();        //2
        }

        public void Configure(IApplicationBuilder app)
        {
            //app.UseWelcomePage();     //1

            //app.UseStaticFiles();     //2
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            //});

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello SweNug!");
            });
        }
    }
}
