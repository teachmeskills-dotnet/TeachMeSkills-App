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
        }
    }
}
