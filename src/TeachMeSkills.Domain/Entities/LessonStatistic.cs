using TeachMeSkills.Common.Interfaces;

namespace TeachMeSkills.Domain.Entities
{
    /// <summary>
    /// Lesson statistic.
    /// </summary>
    public class LessonStatistic : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// Lesson identifier.
        /// </summary>
        public int LessonId { get; set; }

        /// <summary>
        /// Navigation to Lesson.
        /// </summary>
        public Lesson Lesson { get; set; }

        /// <summary>
        /// Statistic identifier.
        /// </summary>
        public int StatisticId { get; set; }

        /// <summary>
        /// Navigation to Statistic.
        /// </summary>
        public Statistic Statistic { get; set; }
    }
}
