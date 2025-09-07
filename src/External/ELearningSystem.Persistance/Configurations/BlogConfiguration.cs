using ELearningSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearningSystem.Persistance.Configurations;

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        builder.ToTable("Blogs");
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Title).HasColumnName(nameof(Blog.Title)).HasMaxLength(200).HasColumnType("nvarchar(200)").IsRequired();
        builder.Property(b => b.Content).HasColumnName(nameof(Blog.Content)).HasMaxLength(500).HasColumnType("nvarchar(500)").IsRequired();
        builder.Property(b => b.ImageUrl).HasColumnName(nameof(Blog.ImageUrl)).HasMaxLength(300).HasColumnType("nvarchar(200)").IsRequired();
        builder.Property(b => b.PublishDate).HasColumnName(nameof(Blog.PublishDate)).HasColumnType("datetime").IsRequired();

        builder.HasOne(b => b.BlogCategory).WithMany(bc => bc.Blogs).HasForeignKey(b => b.BlogCategoryId).OnDelete(DeleteBehavior.Cascade);
    }
}
