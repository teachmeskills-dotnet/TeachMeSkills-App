using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TeachMeSkills.Application.Context
{
    /// <summary>
    /// Database context.
    /// </summary>
    public class TeachMeSkillsContext : IdentityDbContext
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="options">DbContextOptions.</param>
        public TeachMeSkillsContext(DbContextOptions<TeachMeSkillsContext> options)
            : base(options) { }
    }
}
