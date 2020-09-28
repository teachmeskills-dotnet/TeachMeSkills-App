using System;
using TeachMeSkills.Common.Interfaces;

namespace TeachMeSkills.Domain.Entities
{
    /// <summary>
    /// Profile.
    /// </summary>
    public class Profile : IHasDbIdentity, IHasUserIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <inheritdoc/>
        public string UserId { get; set; }

        /// <summary>
        /// Navigation to ApplicationUser.
        /// </summary>
        public ApplicationUser User { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Middle name.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Birth date.
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Phone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Telegram username.
        /// </summary>
        public string Telegram { get; set; }

        /// <summary>
        /// Social network for contact.
        /// </summary>
        public string SocialNetwork { get; set; }

        /// <summary>
        /// Is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Telegram chat id for Bot.
        /// </summary>
        public string ChatId { get; set; }

        /// <summary>
        /// Telegram secret key.
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// Created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Last edited.
        /// </summary>
        public DateTime? LastEdited { get; set; }
    }
}
