using Delirio.Modules.Email.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delirio.Infrastructure.Mappings.EFCore
{
    public class StoreMap : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(k => k.Id)
               .HasColumnName("Id");
            
            builder.Property(k => k.StoreName)
                .HasColumnName("StoreName")
                .HasColumnType("varchar(250)")
                .HasMaxLength(250)
                .IsRequired();

            builder.OwnsOne(p => p.Cnpj)
                            .Property(p => p.CnpjNumero).HasColumnName("CpfNumero");
        }
    }
}