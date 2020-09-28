using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TeachMeSkills.Common.Constants;
using TeachMeSkills.Domain.Entities;

namespace TeachMeSkills.Application.Configurations
{
    /// <summary>
    /// EF Configuration for Group entity.
    /// </summary>
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Groups, SchemaConstants.Group)
                .HasKey(group => group.Id);

            builder.Property(group => group.Serial)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthLong);

            builder.Property(group => group.Comment)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(group => group.Start)
                .HasColumnType(ConfigurationContants.SqlDateFormat);

            builder.Property(group => group.End)
                .HasColumnType(ConfigurationContants.SqlDateFormat);

            builder.HasOne(group => group.Course)
                .WithMany(course => course.Groups)
                .HasForeignKey(group => group.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
