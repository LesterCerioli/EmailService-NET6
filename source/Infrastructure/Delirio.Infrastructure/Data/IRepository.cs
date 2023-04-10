using Delirio.Infrastructure.Models;

namespace Delirio.Infrastructure.Data
{
    public interface IRepository<T> : IRepositoryWithTypedId<T, long> where T : IEntityWithTypedId<long>
    {
         
    }
}