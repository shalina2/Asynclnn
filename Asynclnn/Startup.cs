﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asynclnn.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Asynclnn

{

    public class Startup
    {

        public IConfiguration Configuration { get; }//  readonly

        public Startup(IConfiguration configuration)// enable us to use multiple applications

        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<AsyncDbContext>(options =>// make dbcontext and send the options
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")) // after this application db context will be treated as a singleton



            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();//help us use css
            app.UseMvc(routes =>

            {
                routes.MapRoute(
                name: "default",            
                template: "{controller=Home}/{action=Index}/{id?}");// its route that goes to index page

            });

        }
    }
}
