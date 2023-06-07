using Delirio.Modules.Email.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delirio.Infrastructure.Mappings.EFCore
{
    public class PaymentMachineMap : IEntityTypeConfiguration<PaymentMachine>
    {
        //Index: w
        public void Configure(EntityTypeBuilder<PaymentMachine> builder)
        {
            builder.HasKey(w => w.Id);

            builder.Property(w => w.Id)
                .HasColumnName("Id");

            builder.Property(w => w.IpAddress)
                .HasColumnName("IpAddress")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.OwnsOne(p => p.Address)
                .Property(p => p.Street).HasColumnName("Street");

            builder.OwnsOne(p => p.Address)
                .Property(p => p.Number).HasColumnName("Number");

            builder.OwnsOne(p => p.Address)
                .Property(p => p.Complement).HasColumnName("Complement");

            builder.OwnsOne(p => p.Address)
                .Property(p => p.District).HasColumnName("District");

            builder.OwnsOne(p => p.Address)
                .Property(p => p.City).HasColumnName("City");

            builder.OwnsOne(p => p.Address)
                .Property(p => p.State).HasColumnName("State");

            builder.OwnsOne(p => p.Address)
                .Property(p => p.Country).HasColumnName("Country");






        }
    }
}