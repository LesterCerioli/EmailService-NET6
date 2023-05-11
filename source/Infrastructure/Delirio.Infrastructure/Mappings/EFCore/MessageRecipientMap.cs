using Delirio.Modules.Email.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delirio.Infrastructure.Mappings.EFCore
{
    public class MessageRecipientMap : IEntityTypeConfiguration<MessageRecipient>
    {
                        
        public void Configure(EntityTypeBuilder<MessageRecipient> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id)
               .HasColumnName("Id");
        }
    }
}