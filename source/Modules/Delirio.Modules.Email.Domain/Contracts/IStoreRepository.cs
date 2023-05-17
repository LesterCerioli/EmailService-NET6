using Delirio.Modules.Email.Domain.Models;
using Delirio.Modules.Email.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Domain.Contracts
{
    public interface IStoreRepository
    {
        Task<Store> GetByStoreName(string storeName);

        Task<Store> GetByCnpj(Cnpj cnpj);

        Task<IEnumerable<Store>> GetAll();

        Task Add(Store store);
        
        void Update(Store store);

        void Remove(Store store);
    }
}
