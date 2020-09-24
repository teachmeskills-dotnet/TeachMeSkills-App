﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TeachMeSkills.Common.Constants;
using TeachMeSkills.Domain.Entities;

namespace TeachMeSkills.Application.Configurations
{
    /// <summary>
    /// EF Configuration for Course entity.
    /// </summary>
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Courses, SchemaConstants.Course)
                .HasKey(course => course.Id);

            builder.Property(course => course.Name)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.StandartLenghtForStringField);

            builder.Property(course => course.Comment)
                .HasMaxLength(ConfigurationContants.StandartLenghtForStringField);

            builder.HasMany(course => course.CourseMaterials)
                .WithOne(courseMaterial => courseMaterial.Course)
                .HasForeignKey(courseMaterial => courseMaterial.CourseId);
        }
    }
}
