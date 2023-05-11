using Delirio.Modules.Email.Domain.Modules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delirio.Infrastructure.Mappings.EFCore
{
    public class OrderEmailMap : IEntityTypeConfiguration<OrderEmail>
    {
        public void Configure(EntityTypeBuilder<OrderEmail> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
               .HasColumnName("Id");
            
            builder.Property(a => a.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar(200)")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}