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
    public class GroupDetailConfiguration : IEntityTypeConfiguration<GroupDetail>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<GroupDetail> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.GroupDetails, SchemaConstants.Group)
                .HasKey(groupDetail => groupDetail.Id);

            builder.Property(groupDetail => groupDetail.Contract)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(groupDetail => groupDetail.UserId)
                .IsRequired();

            builder.Property(groupDetail => groupDetail.Start)
                .HasColumnType(ConfigurationContants.SqlDateFormat);

            builder.Property(groupDetail => groupDetail.End)
                .HasColumnType(ConfigurationContants.SqlDateFormat);

            builder.Property(groupDetail => groupDetail.Certificate)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(groupDetail => groupDetail.Comment)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.HasOne(groupDetail => groupDetail.Group)
                .WithMany(group => group.GroupDetails)
                .HasForeignKey(groupDetail => groupDetail.GroupId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(groupDetail => groupDetail.User)
                .WithMany(user => user.GroupDetails)
                .HasForeignKey(groupDetail => groupDetail.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
