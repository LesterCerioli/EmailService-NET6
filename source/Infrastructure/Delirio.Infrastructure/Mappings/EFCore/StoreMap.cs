using Delirio.Modules.Email.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delirio.Infrastructure.Mappings.EFCore
{
    public class StoreMap : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            
            // Map properties to columns
            builder.HasKey(s => s.Id); // Assuming Id is the primary key
            builder.Property(s => s.StoreName)
                .HasMaxLength(255)
                .HasColumnName("StoreName")
                .HasMaxLength(255)
                .HasColumnType("varchar(255)")
                .IsRequired();


            builder.Property(s => s.ManagerName)
                .HasMaxLength(255)
                .HasColumnName("ManagerName")
                .HasMaxLength(255)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(s => s.District)
                .HasColumnName("District")
                .HasColumnType("varchar(100")
                .HasMaxLength(100)
                .IsRequired();
            
            builder.OwnsOne(p => p.Address)
                            .Property(p => p.Street).HasColumnName("Street");

            builder.OwnsOne(p => p.Address)
                            .Property(p => p.City).HasColumnName("City");

            builder.OwnsOne(p => p.Address)
                            .Property(p => p.State).HasColumnName("State");

            builder.OwnsOne(p => p.Address)
                            .Property(p => p.PostalCode).HasColumnName("PostalCode");

            builder.OwnsOne(p => p.Cnpj)
                            .Property(p => p.CnpjNumber)
                            .HasColumnName("CnpjNumber");

            builder.OwnsOne(p => p.Telephone)
                            .Property(p => p.TelephoneRegion)
                            .HasColumnName("RegionCode");

            builder.OwnsOne(p => p.Telephone)
                            .Property(p => p.TelephoneNumber)
                            .HasColumnName("TelephoneNumber");

            builder.OwnsOne(p => p.Telephone)
                            .Property(p => p.TelephoneNumber2)
                            .HasColumnName("TelephoneNumber2");



            builder.Property(s => s.SocialReason)
                .HasMaxLength(255)
                .HasColumnName("SocialReason")
                .HasColumnType("varchar(255")
                .IsRequired();
            
            
            
        }
    }
}