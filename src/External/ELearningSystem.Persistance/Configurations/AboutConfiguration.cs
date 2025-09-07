using ELearningSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearningSystem.Persistance.Configurations;

public class AboutConfiguration : IEntityTypeConfiguration<About>
{
    public void Configure(EntityTypeBuilder<About> builder)
    {
        builder.ToTable("Abouts");
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Title).HasColumnName(nameof(About.Title)).HasMaxLength(200).IsRequired();
        builder.Property(a => a.Description).HasColumnName(nameof(About.Description)).HasMaxLength(500).IsRequired();
        builder.Property(a => a.ImageUrl).HasColumnName(nameof(About.ImageUrl)).HasMaxLength(300).IsRequired();
        builder.Property(a => a.Item1).HasColumnName(nameof(About.Item1)).HasMaxLength(100).IsRequired();
        builder.Property(a => a.Item2).HasColumnName(nameof(About.Item2)).HasMaxLength(100).IsRequired();
        builder.Property(a => a.Item3).HasColumnName(nameof(About.Item3)).HasMaxLength(100).IsRequired();
        builder.Property(a => a.Item4).HasColumnName(nameof(About.Item4)).HasMaxLength(100).IsRequired();
    }
}
