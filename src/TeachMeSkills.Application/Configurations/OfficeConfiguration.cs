using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TeachMeSkills.Common.Constants;
using TeachMeSkills.Domain.Entities;

namespace TeachMeSkills.Application.Configurations
{
    /// <summary>
    /// EF Configuration for Office entity.
    /// </summary>
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Offices, SchemaConstants.Lesson)
                .HasKey(office => office.Id);

            builder.Property(office => office.Location)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(office => office.Room)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthShort);

            builder.Property(office => office.Floor)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthShort);

            builder.Property(office => office.Phone)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthShort);

            builder.Property(office => office.Comment)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium); // TODO: change to long 
        }
    }
}
