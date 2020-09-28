using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TeachMeSkills.Common.Constants;
using TeachMeSkills.Domain.Entities;

namespace TeachMeSkills.Application.Configurations
{
    /// <summary>
    /// EF Configuration for Statistic entity.
    /// </summary>
    public class StatisticConfiguration : IEntityTypeConfiguration<Statistic>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Statistic> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Statistics, SchemaConstants.Lesson)
                .HasKey(statistic => statistic.Id);

            builder.Property(statistic => statistic.UserId)
                .IsRequired();

            builder.Property(statistic => statistic.Comment)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthLong);

            builder.HasOne(statistic => statistic.User)
                .WithMany(user => user.Statistics)
                .HasForeignKey(statistic => statistic.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
