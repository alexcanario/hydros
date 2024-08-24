using Hydros.Domain.Entities.Customers;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hydros.Infra.Data.Configuration;

public class CustomerConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customers");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).HasMaxLength(100).IsRequired(true);
        builder.Property(c => c.Identification).HasMaxLength(20);
        builder.Property(c => c.Nim).HasMaxLength(20);
        builder.Property(c => c.TaxPayerId).HasMaxLength(20);
        builder.Property(c => c.CustomerType).IsRequired(true);
        builder.Property(c => c.Email).HasMaxLength(100).IsRequired(true);
        builder.Property(c => c.PhoneNumber).HasMaxLength(20).IsRequired();
        builder.Property(c => c.PhoneNumberBackup).HasMaxLength(20);
    }
}