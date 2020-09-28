using System;
using System.Collections.Generic;
using TeachMeSkills.Common.Interfaces;

namespace TeachMeSkills.Domain.Entities
{
    /// <summary>
    /// Group.
    /// </summary>
    public class Group : IHasDbIdentity, IHasComment
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
        /// Serial.
        /// </summary>
        public string Serial { get; set; }

        /// <summary>
        /// Start.
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// End.
        /// </summary>
        public DateTime? End { get; set; }

        /// <inheritdoc/>
        public string Comment { get; set; }

        /// <summary>
        /// Navigation to GroupDetails.
        /// </summary>
        public ICollection<GroupDetail> GroupDetails { get; set; }

        /// <summary>
        /// Navigation to Lessons.
        /// </summary>
        public ICollection<Lesson> Lessons { get; set; }
    }
}
