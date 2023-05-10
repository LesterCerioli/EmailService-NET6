using Delirio.Modules.Email.Domain.Modules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delirio.Infrastructure.Mappings.EFCore
{
    public class OrderEmailMap : IEntityTypeConfiguration<OrderEmail>
    {
        public void Configure(EntityTypeBuilder<OrderEmail> builder)
        {
            throw new NotImplementedException();
        }
    }
}