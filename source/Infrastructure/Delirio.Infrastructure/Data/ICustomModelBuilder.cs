using Microsoft.EntityFrameworkCore;

namespace Delirio.Infrastructure.Data
{
    public interface ICustomModelBuilder
    {
        void Build(ModelBuilder modelBuilder);
    }
}