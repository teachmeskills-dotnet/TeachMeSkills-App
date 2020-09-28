﻿using System;
using TeachMeSkills.Common.Interfaces;

namespace TeachMeSkills.Domain.Entities
{
    /// <summary>
    /// Group detail.
    /// </summary>
    public class GroupDetail : IHasDbIdentity, IHasUserIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// Group identifier.
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// Navigation to group.
        /// </summary>
        public Group Group { get; set; }

        /// <inheritdoc/>
        public string UserId { get; set; }

        /// <summary>
        /// Navigation to application user.
        /// </summary>
        public ApplicationUser User { get; set; }

        /// <summary>
        /// Is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Academic leave type.
        /// </summary>
        public int AcademicLeaveType { get; set; }

        /// <summary>
        /// Contract.
        /// </summary>
        public string Contract { get; set; }

        /// <summary>
        /// Start.
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// End.
        /// </summary>
        public DateTime? End { get; set; }

        /// <summary>
        /// Certificate.
        /// </summary>
        public string Certificate { get; set; }

        /// <summary>
        /// Comment.
        /// </summary>
        public string Comment { get; set; }
    }
}
