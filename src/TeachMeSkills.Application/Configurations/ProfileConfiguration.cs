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
                .HasKey(p => p.Id);

            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.StandartLenghtForStringField);

            builder.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.StandartLenghtForStringField);

            builder.Property(p => p.MiddleName)
                .HasMaxLength(ConfigurationContants.StandartLenghtForStringField);

            builder.Property(p => p.BirthDate)
                .HasColumnType(ConfigurationContants.DateFormat);

            builder.Property(p => p.Phone)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.StandartLenghtForStringField);

            builder.Property(p => p.Phone)
                .HasMaxLength(ConfigurationContants.StandartLenghtForStringField);

            builder.Property(p => p.Telegram)
                .HasMaxLength(ConfigurationContants.StandartLenghtForStringField);

            builder.Property(p => p.Telegram)
                .HasMaxLength(ConfigurationContants.StandartLenghtForStringField);

            builder.Property(p => p.SocialNetwork)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.MaxLenghtForStringField);

            builder.Property(p => p.ChatId)
                .HasMaxLength(ConfigurationContants.MaxLenghtForStringField);

            builder.Property(p => p.SecretKey)
                .HasMaxLength(ConfigurationContants.MaxLenghtForStringField);

            builder.HasOne(p => p.User)
                .WithOne(i => i.Profile)
                .HasForeignKey<Profile>(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
