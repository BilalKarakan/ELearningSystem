using ELearningSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearningSystem.Persistance.Configurations;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.ToTable("Courses");
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name).HasColumnName(nameof(Course.Name)).HasMaxLength(200).HasColumnType("nvarchar(200)").IsRequired();
        builder.Property(c => c.ImageUrl).HasColumnName(nameof(Course.ImageUrl)).HasMaxLength(200).HasColumnType("nvarchar(200)").IsRequired();
        builder.Property(c => c.Price).HasColumnName(nameof(Course.Price)).HasColumnType("decimal(10,4)").IsRequired();
        builder.Property(c => c.Description).HasColumnName(nameof(Course.Description)).HasMaxLength(2000).HasColumnType("nvarchar(2000)").IsRequired();
        builder.Property(c => c.IsShown).HasColumnName(nameof(Course.IsShown)).HasColumnType("bit").IsRequired();

        builder.HasOne(c => c.CourseCategory).WithMany(cc => cc.Courses).HasForeignKey(c => c.CourseCategoryId).OnDelete(DeleteBehavior.Cascade);
    }
}
