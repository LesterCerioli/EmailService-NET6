using Delirio.Modules.Email.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delirio.Infrastructure.Mappings.EFCore
{
    public class MessageQueueMap : IEntityTypeConfiguration<MessageQueue>
    {
        public void Configure(EntityTypeBuilder<MessageQueue> builder)
        {
            throw new NotImplementedException();
        }
    }
}