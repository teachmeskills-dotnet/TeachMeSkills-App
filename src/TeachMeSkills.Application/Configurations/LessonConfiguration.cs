using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TeachMeSkills.Common.Constants;
using TeachMeSkills.Domain.Entities;

namespace TeachMeSkills.Application.Configurations
{
    /// <summary>
    /// EF Configuration for GroupDetail entity.
    /// </summary>
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Lessons, SchemaConstants.Lesson)
                .HasKey(lesson => lesson.Id);

            builder.Property(lesson => lesson.Start)
                .HasColumnType(ConfigurationContants.SqlDateFormat);

            builder.Property(lesson => lesson.End)
                .HasColumnType(ConfigurationContants.SqlDateFormat);

            builder.Property(lesson => lesson.Record)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(lesson => lesson.Comment)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthLong);

            builder.HasOne(lesson => lesson.CourseMaterial)
                .WithMany(courseMaterial => courseMaterial.Lessons)
                .HasForeignKey(lesson => lesson.CourseMaterialId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(lesson => lesson.Group)
                .WithMany(group => group.Lessons)
                .HasForeignKey(lesson => lesson.GroupId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(lesson => lesson.Office)
                .WithMany(office => office.Lessons)
                .HasForeignKey(lesson => lesson.OfficeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
