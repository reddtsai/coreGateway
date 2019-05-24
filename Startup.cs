using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace gateway
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOcelot(_config);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseOcelot().Wait();
            // if (env.IsDevelopment())
            // {
            //     app.UseDeveloperExceptionPage();
            // }

            // app.Run(async (context) =>
            // {
            //     await context.Response.WriteAsync("Hello World!");
            // });
        }
    }
}
