using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TeachMeSkills.Common.Constants;
using TeachMeSkills.Domain.Entities;

namespace TeachMeSkills.Application.Configurations
{
    /// <summary>
    /// EF Configuration for Exercise entity.
    /// </summary>
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Exercises, SchemaConstants.Lesson)
                .HasKey(exercise => exercise.Id);

            builder.Property(exercise => exercise.Text)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthLong);

            builder.Property(exercise => exercise.Link)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(exercise => exercise.Comment)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthLong);
        }
    }
}
