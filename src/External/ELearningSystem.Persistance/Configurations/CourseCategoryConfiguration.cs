using ELearningSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearningSystem.Persistance.Configurations;

public class CourseCategoryConfiguration : IEntityTypeConfiguration<CourseCategory>
{
    public void Configure(EntityTypeBuilder<CourseCategory> builder)
    {
        builder.ToTable("CourseCategories");
        builder.HasKey(cc => cc.Id);

        builder.Property(cc => cc.Name).HasColumnName(nameof(CourseCategory.Name)).HasMaxLength(200).HasColumnType("nvarchar(200)").IsRequired();
        builder.Property(cc => cc.Icon).HasColumnName(nameof(CourseCategory.Icon)).HasMaxLength(100).HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(cc => cc.Description).HasColumnName(nameof(CourseCategory.Description)).HasMaxLength(500).HasColumnType("nvarchar(500)").IsRequired();
        builder.Property(cc => cc.IsShown).HasColumnName(nameof(CourseCategory.IsShown)).HasColumnType("bit").IsRequired();

        builder.HasMany(cc => cc.Courses).WithOne(c => c.CourseCategory).HasForeignKey(c => c.CourseCategoryId).OnDelete(DeleteBehavior.Cascade);
    }
}
