using System;
using System.Collections.Generic;
using TeachMeSkills.Common.Interfaces;

namespace TeachMeSkills.Domain.Entities
{
    /// <summary>
    /// Lesson.
    /// </summary>
    public class Lesson : IHasDbIdentity, IHasComment
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// CourseMaterial identifier.
        /// </summary>
        public int CourseMaterialId { get; set; }

        /// <summary>
        /// Navigation to CourseMaterial.
        /// </summary>
        public CourseMaterial CourseMaterial { get; set; }

        /// <summary>
        /// Group identifier.
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// Navigation to Group.
        /// </summary>
        public Group Group { get; set; }

        /// <summary>
        /// Office identifier.
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Navigation to Office.
        /// </summary>
        public Office Office { get; set; }

        /// <summary>
        /// Date.
        /// </summary>
        public DateTime Date { get; set; }
        
        /// <summary>
        /// Start.
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// End.
        /// </summary>
        public DateTime End { get; set; }

        /// <summary>
        /// Is canceled.
        /// </summary>
        public bool IsCanceled { get; set; }

        /// <summary>
        /// Is offline.
        /// </summary>
        public bool IsOffline { get; set; }

        /// <summary>
        /// Record.
        /// </summary>
        public string Record { get; set; }

        /// <inheritdoc/>
        public string Comment { get; set; }

        /// <summary>
        /// Navigation to LessonStatistics.
        /// </summary>
        public ICollection<LessonStatistic> LessonStatistics { get; set; }

        /// <summary>
        /// Navigation to Homeworks.
        /// </summary>
        public ICollection<Homework> Homeworks { get; set; }
    }
}
