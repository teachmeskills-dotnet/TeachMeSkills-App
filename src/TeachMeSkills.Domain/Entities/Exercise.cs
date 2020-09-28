using System.Collections.Generic;
using TeachMeSkills.Common.Interfaces;

namespace TeachMeSkills.Domain.Entities
{
    /// <summary>
    /// Exercise.
    /// </summary>
    public class Exercise : IHasDbIdentity, IHasComment
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// Text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Link.
        /// </summary>
        public string Link { get; set; }

        /// <inheritdoc/>
        public string Comment { get; set; }

        /// <summary>
        /// Navigation to Homeworks.
        /// </summary>
        public ICollection<Homework> Homeworks { get; set; }
    }
}
