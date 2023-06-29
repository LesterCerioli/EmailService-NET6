using Delirio.Modules.Email.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delirio.Infrastructure.Mappings.EFCore
{
    public class MessageRecipientMap : IEntityTypeConfiguration<MessageRecipient>
    {
        public void Configure(EntityTypeBuilder<MessageRecipient> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.RecipientMail)
                .HasMaxLength(200)
                .IsRequired();

            builder.HasMany(m => m.MessageQueues)
                .WithOne()
                .HasForeignKey("MessageRecipientId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}