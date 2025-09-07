using ELearningSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearningSystem.Persistance.Configurations;

public class TestimonialConfiguration : IEntityTypeConfiguration<Testimonial>
{
    public void Configure(EntityTypeBuilder<Testimonial> builder)
    {
        builder.ToTable("Testimonials");
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Name).HasColumnName(nameof(Testimonial.Name)).HasMaxLength(200).HasColumnType("nvarchar(200)").IsRequired();
        builder.Property(t => t.Title).HasColumnName(nameof(Testimonial.Title)).HasMaxLength(300).HasColumnType("nvarchar(300)").IsRequired();
        builder.Property(t => t.ImageUrl).HasColumnName(nameof(Testimonial.ImageUrl)).HasMaxLength(200).HasColumnType("nvarchar(200)").IsRequired();
        builder.Property(t => t.Comment).HasColumnName(nameof(Testimonial.Comment)).HasMaxLength(500).HasColumnType("nvarchar(500)").IsRequired();
        builder.Property(t => t.Star).HasColumnName(nameof(Testimonial.Star)).HasColumnType("int").IsRequired();
    }
}
