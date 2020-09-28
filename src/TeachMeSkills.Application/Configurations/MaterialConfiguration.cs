using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TeachMeSkills.Common.Constants;
using TeachMeSkills.Domain.Entities;

namespace TeachMeSkills.Application.Configurations
{
    /// <summary>
    /// EF Configuration for Material entity.
    /// </summary>
    public class MaterialConfiguration : IEntityTypeConfiguration<Material>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Materials, SchemaConstants.Course)
                .HasKey(material => material.Id);

            builder.Property(material => material.Topic)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthLong);

            builder.Property(material => material.Comment)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthLong);
        }
    }
}
