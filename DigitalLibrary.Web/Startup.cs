using DigitalLibrary.Web.Middleware;
using DigitalLibrary.Web.MiddlewareExtensions;
using DigitalLibrary.Web.Models;
using DigitalLibrary.Web.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DigitalLibrary.Web
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
            var connection = Configuration.GetConnectionString("DefaultConnection");
            if (connection == null)
                connection = "testingconnection";
            //services.AddDbContext<DigitalLibraryContext>(options =>
            //    options.UseSqlServer(connection));
            services.AddEntityFrameworkNpgsql()
                .AddDbContext<DigitalLibraryContext>(options =>
                    options.UseNpgsql(connection));
            services.AddMvc();
            //services.AddTransient<EmailService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseSimpleMiddleware();
            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();
        }
    }
}
