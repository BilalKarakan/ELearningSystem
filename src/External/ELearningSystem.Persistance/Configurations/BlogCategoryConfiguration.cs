using ELearningSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearningSystem.Persistance.Configurations;

public class BlogCategoryConfiguration : IEntityTypeConfiguration<BlogCategory>
{
    public void Configure(EntityTypeBuilder<BlogCategory> builder)
    {
        builder.ToTable("BlogCategories");
        builder.HasKey(bc => bc.Id);

        builder.Property(bc => bc.Name).HasColumnName(nameof(BlogCategory.Name)).HasMaxLength(200).HasColumnType("nvarchar(200)").IsRequired();

        builder.HasMany(bc => bc.Blogs).WithOne(b => b.BlogCategory).HasForeignKey(b => b.BlogCategoryId).OnDelete(DeleteBehavior.Cascade);
    }
}
