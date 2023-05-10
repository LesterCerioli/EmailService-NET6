using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delirio.Infrastructure.Mappings.EFCore
{
    public class MessageRecipientMap : IEntityTypeConfiguration<MessageRecipientMap>
    {
        public void Configure(EntityTypeBuilder<MessageRecipientMap> builder)
        {
            throw new NotImplementedException();
        }
    }
}