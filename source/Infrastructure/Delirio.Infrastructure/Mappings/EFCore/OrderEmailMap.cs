using Delirio.Modules.Email.Domain.Modules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delirio.Infrastructure.Mappings.EFCore
{
    public class OrderEmailMap : IEntityTypeConfiguration<OrderEmail>
    {
        public void Configure(EntityTypeBuilder<OrderEmail> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Email)
                .HasMaxLength(200);

            builder.HasOne(o => o.Store)
                .WithMany()
                .HasForeignKey(o => o.StoreId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(o => o.Stores)
                .WithOne()
                .HasForeignKey("OrderEmailId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}