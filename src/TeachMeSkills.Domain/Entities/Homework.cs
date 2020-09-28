using TeachMeSkills.Common.Interfaces;

namespace TeachMeSkills.Domain.Entities
{
    /// <summary>
    /// Homework.
    /// </summary>
    public class Homework : IHasDbIdentity, IHasUserIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// Lesson identifier.
        /// </summary>
        public int? LessonId { get; set; }

        /// <summary>
        /// Navigation to Lesson.
        /// </summary>
        public Lesson Lesson { get; set; }

        /// <inheritdoc/>
        public string UserId { get; set; }

        /// <summary>
        /// Navigation to application user.
        /// </summary>
        public ApplicationUser User { get; set; }

        /// <summary>
        /// Exercise identifier.
        /// </summary>
        public int ExerciseId { get; set; }

        /// <summary>
        /// Navigation to Exercise.
        /// </summary>
        public Exercise Exercise { get; set; }
    }
}
