using Delirio.Modules.Email.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delirio.Infrastructure.Mappings.EFCore
{
    public class PaymentMachineMap : IEntityTypeConfiguration<PaymentMachine>
    {
        public void Configure(EntityTypeBuilder<PaymentMachine> builder)
        {
            builder.HasKey(h => h.Id);

            builder.Property(h => h.Id)
               .HasColumnName("Id");
        }
    }
}