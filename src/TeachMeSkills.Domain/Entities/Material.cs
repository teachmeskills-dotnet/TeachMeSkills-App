using System;
using System.Collections.Generic;
using TeachMeSkills.Common.Interfaces;

namespace TeachMeSkills.Domain.Entities
{
    /// <summary>
    /// Material.
    /// </summary>
    public class Material : IHasDbIdentity, IHasComment
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// Topic.
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// Is actual.
        /// </summary>
        public bool IsActual { get; set; }

        /// <summary>
        /// Created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// LastEdited.
        /// </summary>
        public DateTime? LastEdited { get; set; }

        /// <inheritdoc/>
        public string Comment { get; set; }

        /// <summary>
        /// Navigation to CourseMaterials.
        /// </summary>
        public ICollection<CourseMaterial> CourseMaterials { get; set; }
    }
}
