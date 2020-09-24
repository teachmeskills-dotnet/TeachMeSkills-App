using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TeachMeSkills.Application.Context;

namespace TeachMeSkills.Application.Extensions
{
    public static class ApplicationServiceCollectionExtension
    {
        /// <summary>
        /// Dependency injection.
        /// </summary>
        /// <param name="services">Service collection.</param>
        /// <param name="configuration">Configuration.</param>
        /// <returns>Service collection.</returns>
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TeachMeSkillsContext>(options => options.UseSqlServer(configuration.GetConnectionString("TeachMeSkillsApp")));

            services.AddIdentityCore<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<TeachMeSkillsContext>();
            //.AddDefaultTokenProviders();

            return services;
        }
    }
}
