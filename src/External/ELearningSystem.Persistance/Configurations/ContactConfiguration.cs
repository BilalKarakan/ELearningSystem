using ELearningSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearningSystem.Persistance.Configurations;

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("Contacts");
        builder.HasKey(c => c.Id);

        builder.Property(c => c.MapUrl).HasColumnName(nameof(Contact.MapUrl)).HasMaxLength(300).HasColumnType("nvarchar(300)").IsRequired();
        builder.Property(c => c.Address).HasColumnName(nameof(Contact.Address)).HasMaxLength(400).HasColumnType("nvarchar(400)").IsRequired();
        builder.Property(c => c.Email).HasColumnName(nameof(Contact.Email)).HasMaxLength(100).HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(c => c.Phone).HasColumnName(nameof(Contact.Phone)).HasMaxLength(20).HasColumnType("nvarchar(20)").IsRequired();
    }
}
