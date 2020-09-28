using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TeachMeSkills.Common.Constants;
using TeachMeSkills.Domain.Entities;

namespace TeachMeSkills.Application.Configurations
{
    /// <summary>
    /// EF Configuration for LessonStatistic entity.
    /// </summary>
    public class LessonStatisticConfiguration : IEntityTypeConfiguration<LessonStatistic>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<LessonStatistic> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.LessonStatistics, SchemaConstants.Lesson)
                .HasKey(lessonStatistic => lessonStatistic.Id);

            builder.HasOne(lessonStatistic => lessonStatistic.Lesson)
                .WithMany(lesson => lesson.LessonStatistics)
                .HasForeignKey(lessonStatistic => lessonStatistic.LessonId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(lessonStatistic => lessonStatistic.Statistic)
                .WithMany(statistic => statistic.LessonStatistics)
                .HasForeignKey(lessonStatistic => lessonStatistic.StatisticId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
