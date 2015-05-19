﻿using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using WebAPI.Services;

namespace WebAPI
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<GreeterService, GreeterService>();

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}
