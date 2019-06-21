using System;
using Crudelicious.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Crudelicious
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration {get; set;}

        public void ConfigureServices (IServiceCollection services)
        {
            // string mySqlConnection = "server=localhost;userid=root;password=root;port=3306;database=dishesdb;SslMode=None";
            services.AddDbContext<CrudeliciousContext> (options => options.UseMySql (Configuration["DBInfo:ConnectionString"]));
            services.AddSession ();
            services.AddMvc ();
        }

        public Startup (IHostingEnvironment env)
        {
            Console.WriteLine (env.ContentRootPath);
            Console.WriteLine (env.IsDevelopment ());
        }

        public Startup (IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment ())
            {
                app.UseDeveloperExceptionPage ();
            }

            app.UseSession ();
            app.UseStaticFiles ();
            app.UseMvc ();
        }
    }
}