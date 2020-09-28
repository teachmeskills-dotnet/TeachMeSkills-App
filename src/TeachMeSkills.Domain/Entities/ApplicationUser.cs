using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

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

        /// <summary>
        /// Navigation to GroupDetails.
        /// </summary>
        public ICollection<GroupDetail> GroupDetails { get; set; }

        /// <summary>
        /// Navigation to Statistics.
        /// </summary>
        public ICollection<Statistic> Statistics { get; set; }

        /// <summary>
        /// Navigation to Homeworks.
        /// </summary>
        public ICollection<Homework> Homeworks { get; set; }
    }
}
