using ELearningSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearningSystem.Persistance.Configurations;

public class SubscriberConfiguration : IEntityTypeConfiguration<Subscriber>
{
    public void Configure(EntityTypeBuilder<Subscriber> builder)
    {
        builder.ToTable("Subscribers");
        builder.HasKey(s => s.Id);

        builder.Property(s => s.Email).HasColumnName(nameof(Subscriber.Email)).HasMaxLength(100).HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(s => s.IsActive).HasColumnName(nameof(Subscriber.IsActive)).HasColumnType("bit").IsRequired();
    }
}
