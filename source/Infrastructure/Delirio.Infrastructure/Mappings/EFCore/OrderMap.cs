using Delirio.Modules.Email.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delirio.Infrastructure.Mappings.EFCore
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);
            
            builder.Property(o => o.OrderBy)
                .HasColumnName("OrderBy")
                .HasColumnType("varchar(90)")
                .HasMaxLength(90)
                .IsRequired();
            
            builder.Property(o => o.TotalValue)
               .HasColumnName("TotalValue")
               .HasColumnType("numeric(8,2)")
               .IsRequired();

            builder.Property(o => o.OrderDate)
               .HasColumnName("OrderDate")
               .HasColumnType("datetime(6)")
               .IsRequired();
            
            
            
            builder.Property(o => o.PickUpDate)
               .HasColumnName("PickUpDate")
               .HasColumnType("datetime(6)")
               .IsRequired();

            builder.Property(o => o.PaymentIndicDate)
               .HasColumnName("PaymentIndicDate")
               .HasColumnType("datetime(6)")
               .IsRequired();

            
            builder.Property(o => o.IndicNatalNormalReveia)
                .HasColumnName("IndicNatalNormalReveia")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(o => o.Flag)
                .HasColumnName("Flag")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(o => o.SentEmail)
                .HasColumnName("SentEmail")
                .HasColumnType("bit")
                .IsRequired();

            builder.OwnsOne(o => o.Telephone)
                            .Property(o => o.TelephoneNumber).HasColumnName("TelephoneNumber");

            builder.OwnsOne(o => o.DataLog)
                            .Property(o => o.CreationDate).HasColumnName("CreationDate");

            builder.OwnsOne(o => o.DataLog)
                            .Property(o => o.LastUpdateDate).HasColumnName("LastUpdateDate");

            builder.OwnsOne(o => o.DataLog)
                            .Property(o => o.DeletionDate).HasColumnName("DeletionDate");

            
    
        }
    }
}