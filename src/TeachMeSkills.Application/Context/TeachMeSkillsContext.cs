﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using TeachMeSkills.Application.Configurations;
using TeachMeSkills.Domain.Entities;

namespace TeachMeSkills.Application.Context
{
    /// <summary>
    /// Database context.
    /// </summary>
    public class TeachMeSkillsContext : IdentityDbContext
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="options">DbContextOptions.</param>
        public TeachMeSkillsContext(DbContextOptions<TeachMeSkillsContext> options)
            : base(options) { }

        /// <summary>
        /// Profiles.
        /// </summary>
        public DbSet<Profile> Profiles { get; set; }

        /// <summary>
        /// Courses.
        /// </summary>
        public DbSet<Course> Courses { get; set; }

        /// <summary>
        /// Materials.
        /// </summary>
        public DbSet<Material> Materials { get; set; }

        /// <summary>
        /// Course materials.
        /// </summary>
        public DbSet<CourseMaterial> CourseMaterials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.ApplyConfiguration(new ProfileConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialConfiguration());
            modelBuilder.ApplyConfiguration(new CourseMaterialConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
