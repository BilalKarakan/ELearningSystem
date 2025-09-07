using ELearningSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearningSystem.Persistance.Configurations;

public class BannerConfiguration : IEntityTypeConfiguration<Banner>
{
    public void Configure(EntityTypeBuilder<Banner> builder)
    {
        builder.ToTable("Banners");
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Title).HasColumnName(nameof(Banner.Title)).HasMaxLength(200).IsRequired();
        builder.Property(b => b.ImageUrl).HasColumnName(nameof(Banner.ImageUrl)).HasMaxLength(300).IsRequired();
    }
}
