using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using TeachMeSkills.Application.Configurations;
using TeachMeSkills.Domain.Entities;

namespace TeachMeSkills.Application.Context
{
    /// <summary>
    /// Database context.
    /// </summary>
    public class TeachMeSkillsContext : IdentityDbContext<ApplicationUser>
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

        /// <summary>
        /// Groups.
        /// </summary>
        public DbSet<Group> Groups { get; set; }

        /// <summary>
        /// Group details.
        /// </summary>
        public DbSet<GroupDetail> GroupDetails { get; set; }

        /// <summary>
        /// Offices.
        /// </summary>
        public DbSet<Office> Offices { get; set; }

        /// <summary>
        /// Exercises.
        /// </summary>
        public DbSet<Exercise> Exercises { get; set; }

        /// <summary>
        /// Statistics.
        /// </summary>
        public DbSet<Statistic> Statistics { get; set; }

        /// <summary>
        /// Lessons.
        /// </summary>
        public DbSet<Lesson> Lessons { get; set; }

        /// <summary>
        /// Lesson statistics.
        /// </summary>
        public DbSet<LessonStatistic> LessonStatistics { get; set; }

        /// <summary>
        /// Homeworks.
        /// </summary>
        public DbSet<Homework> Homeworks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.ApplyConfiguration(new ProfileConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialConfiguration());
            modelBuilder.ApplyConfiguration(new CourseMaterialConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new GroupDetailConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new ExerciseConfiguration());
            modelBuilder.ApplyConfiguration(new StatisticConfiguration());
            modelBuilder.ApplyConfiguration(new LessonConfiguration());
            modelBuilder.ApplyConfiguration(new LessonStatisticConfiguration());
            modelBuilder.ApplyConfiguration(new HomeworkConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
