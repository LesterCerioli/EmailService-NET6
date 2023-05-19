using Delirio.Modules.Email.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delirio.Infrastructure.Mappings.EFCore
{
    public class MessageQueueMap : IEntityTypeConfiguration<MessageQueue>
    {
        public void Configure(EntityTypeBuilder<MessageQueue> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Sender)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(m => m.Title)
                .HasMaxLength(300);

            builder.Property(m => m.Body)
                .IsRequired();

            builder.Property(m => m.SendingDate)
                .IsRequired();

            builder.Property(m => m.ShotsNumber)
                .HasMaxLength(50);

            builder.Property(m => m.ErrorName)
                .HasMaxLength(255);

            builder.Property(m => m.CreationDate)
                .IsRequired();

            builder.Property(m => m.LastShotsDate)
                .IsRequired();

            builder.HasOne(m => m.Order)
                .WithMany()
                .HasForeignKey(m => m.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(m => m.Orders)
                .WithOne()
                .HasForeignKey("MessageQueueId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}