using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TeachMeSkills.Common.Constants;
using TeachMeSkills.Domain.Entities;

namespace TeachMeSkills.Application.Configurations
{
    /// <summary>
    /// EF Configuration for CourseMaterial entity.
    /// </summary>
    public class CourseMaterialConfiguration : IEntityTypeConfiguration<CourseMaterial>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<CourseMaterial> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.CourseMaterials, SchemaConstants.Course)
                .HasKey(courseMaterial => courseMaterial.Id);

            builder.HasOne(courseMaterial => courseMaterial.Material)
                .WithMany(material => material.CourseMaterials)
                .HasForeignKey(courseMaterial => courseMaterial.MaterialId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(courseMaterial => courseMaterial.Course)
                .WithMany(course => course.CourseMaterials)
                .HasForeignKey(courseMaterial => courseMaterial.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
