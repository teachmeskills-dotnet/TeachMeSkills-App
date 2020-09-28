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
    public class HomeworkConfiguration : IEntityTypeConfiguration<Homework>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Homeworks, SchemaConstants.Lesson)
                .HasKey(homework => homework.Id);

            builder.HasOne(homework => homework.Lesson)
                .WithMany(lesson => lesson.Homeworks)
                .HasForeignKey(homework => homework.LessonId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(homework => homework.User)
                .WithMany(user => user.Homeworks)
                .HasForeignKey(homework => homework.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(homework => homework.Exercise)
                .WithMany(exercise => exercise.Homeworks)
                .HasForeignKey(homework => homework.ExerciseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
