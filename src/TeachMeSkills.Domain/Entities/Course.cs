﻿using System.Collections.Generic;
using TeachMeSkills.Common.Interfaces;

namespace TeachMeSkills.Domain.Entities
{
    /// <summary>
    /// Course.
    /// </summary>
    public class Course : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Navigation to CourseMaterials.
        /// </summary>
        public ICollection<CourseMaterial> CourseMaterials { get; set; }

        /// <summary>
        /// Navigation to Groups.
        /// </summary>
        public ICollection<Group> Groups { get; set; }
    }
}
