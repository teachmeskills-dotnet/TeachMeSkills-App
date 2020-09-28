using System.Collections.Generic;
using TeachMeSkills.Common.Interfaces;

namespace TeachMeSkills.Domain.Entities
{
    /// <summary>
    /// Statistic.
    /// </summary>
    public class Statistic : IHasDbIdentity, IHasUserIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <inheritdoc/>
        public string UserId { get; set; }

        /// <summary>
        /// Navigation to application user.
        /// </summary>
        public ApplicationUser User { get; set; }

        /// <summary>
        /// Mark.
        /// </summary>
        public int Mark { get; set; }

        /// <summary>
        /// Is visted.
        /// </summary>
        public bool IsVisted { get; set; }

        /// <summary>
        /// Comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Navigation to LessonStatistic.
        /// </summary>
        public ICollection<LessonStatistic> LessonStatistics { get; set; }
    }
}
