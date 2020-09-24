using Microsoft.AspNetCore.Identity;

namespace TeachMeSkills.Domain.Entities
{
    /// <summary>
    /// Application user.
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// Navigation to Profile.
        /// </summary>
        public Profile Profile { get; set; }
    }
}
