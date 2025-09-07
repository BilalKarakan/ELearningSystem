using ELearningSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearningSystem.Persistance.Configurations;

public class SocialMediaConfiguration : IEntityTypeConfiguration<SocialMedia>
{
    public void Configure(EntityTypeBuilder<SocialMedia> builder)
    {
        builder.ToTable("SocialMedias");
        builder.HasKey(sm => sm.Id);

        builder.Property(sm => sm.Icon).HasColumnName(nameof(SocialMedia.Icon)).HasMaxLength(100).HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(sm => sm.Url).HasColumnName(nameof(SocialMedia.Url)).HasMaxLength(300).HasColumnType("nvarchar(300)").IsRequired();
        builder.Property(sm => sm.Title).HasColumnName(nameof(SocialMedia.Title)).HasMaxLength(400).HasColumnType("nvarchar(400)").IsRequired();
    }
}
