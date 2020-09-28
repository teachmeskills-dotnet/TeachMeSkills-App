using System.Collections.Generic;
using TeachMeSkills.Common.Interfaces;

namespace TeachMeSkills.Domain.Entities
{
    /// <summary>
    /// Course material.
    /// </summary>
    public class CourseMaterial : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// Course identifier.
        /// </summary>
        public int CourseId { get; set; }

        /// <summary>
        /// Navigation to Course.
        /// </summary>
        public Course Course { get; set; }

        /// <summary>
        /// Material identifier.
        /// </summary>
        public int MaterialId { get; set; }

        /// <summary>
        /// Navigation to Material.
        /// </summary>
        public Material Material { get; set; }

        /// <summary>
        /// Navigation to Lessons.
        /// </summary>
        public ICollection<Lesson> Lessons { get; set; }
    }
}
