using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TeachMeSkills.Common.Constants;
using TeachMeSkills.Domain.Entities;

namespace TeachMeSkills.Application.Configurations
{
    /// <summary>
    /// EF Configuration for Profile entity.
    /// </summary>
    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Profiles, SchemaConstants.Account)
                .HasKey(profile => profile.Id);

            builder.Property(profile => profile.UserId)
                .IsRequired();

            builder.Property(profile => profile.FirstName)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(profile => profile.LastName)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(profile => profile.MiddleName)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(profile => profile.BirthDate)
                .HasColumnType(ConfigurationContants.SqlDateFormat);

            builder.Property(profile => profile.Phone)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(profile => profile.Phone)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(profile => profile.Telegram)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(profile => profile.Telegram)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(profile => profile.SocialNetwork)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthLong);

            builder.Property(profile => profile.ChatId)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthLong);

            builder.Property(profile => profile.SecretKey)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthLong);

            builder.HasOne(profile => profile.User)
                .WithOne(user => user.Profile)
                .HasForeignKey<Profile>(profile => profile.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
