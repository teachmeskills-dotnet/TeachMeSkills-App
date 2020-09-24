using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using TeachMeSkills.Application.Extensions;

namespace TeachMeSkills.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication(Configuration);

            //services.AddIdentity<IdentityUser, IdentityRole>(config =>
            //{
            //    config.Password.RequiredLength = 4;
            //    config.Password.RequireDigit = false;
            //    config.Password.RequireNonAlphanumeric = false;
            //    config.Password.RequireUppercase = false;
            //    config.SignIn.RequireConfirmedEmail = true;
            //})
            //.AddEntityFrameworkStores<TeachMeSkillsContext>()
            //.AddDefaultTokenProviders();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
