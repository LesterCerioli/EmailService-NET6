using Delirio.Modules.Email.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delirio.Module.Infrastructure.Mappings.EFCore
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
               .HasColumnName("Id");
            
            builder.Property(c => c.CustomerName)
                .HasColumnName("CustomerName")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Email)
               .HasColumnName("Email")
               .HasColumnType("varchar(50)")
               .HasMaxLength(50)
               .IsRequired();

            builder.OwnsOne(p => p.Cpf)
                            .Property(p => p.CPFNumber).HasColumnName("CpfNumero");

            builder.OwnsOne(p => p.DataLog)
                            .Property(p => p.CreationDate).HasColumnName("CreationDate");
            
            builder.OwnsOne(p => p.DataLog)
                            .Property(p => p.LastUpdateDate).HasColumnName("LastUpdateDate");
            
            builder.OwnsOne(p => p.DataLog)
                            .Property(p => p.DeletionDate).HasColumnName("DeletionDate");

            builder.HasMany(c => c.Orders)
               .WithOne(o => o.Customer)
               .HasForeignKey(o => o.Id)
               .OnDelete(DeleteBehavior.Cascade);
            

                        
               
        }
    }
}