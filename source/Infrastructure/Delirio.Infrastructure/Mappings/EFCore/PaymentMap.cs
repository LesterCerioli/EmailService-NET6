using Delirio.Modules.Email.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Infrastructure.Mappings.EFCore
{
    public class PaymentMap : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(h => h.Id);

            builder.Property(h => h.Id)
                .HasColumnName("Id");

            builder.Property(h => h.Id)
                .HasColumnName("AuthorizationCode")
                .HasColumnType("varchar(300)")
                .HasMaxLength(450)
                .IsRequired();
        }
    }
}
