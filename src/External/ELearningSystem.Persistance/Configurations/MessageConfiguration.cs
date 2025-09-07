using ELearningSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearningSystem.Persistance.Configurations;

public class MessageConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.ToTable("Messages");
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Name).HasColumnName(nameof(Message.Name)).HasMaxLength(500).HasColumnType("nvarchar(500)").IsRequired();
        builder.Property(m => m.Subject).HasColumnName(nameof(Message.Subject)).HasMaxLength(200).HasColumnType("nvarchar(200)").IsRequired();
        builder.Property(m => m.Email).HasColumnName(nameof(Message.Email)).HasMaxLength(100).HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(m => m.Content).HasColumnName(nameof(Message.Content)).HasColumnType("nvarchar(max)").IsRequired();
    }
}
