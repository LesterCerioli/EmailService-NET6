using Delirio.Modules.Email.Domain.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Domain.Contracts
{
    public interface IOrderEmailRepository
    {
        Task<OrderEmail> GetByEmail(string email);

        Task<IEnumerable<OrderEmail>> GetAll();

        Task Add(OrderEmail orderEmail);

        void Update(OrderEmail orderEmail);

        void Remove(OrderEmail orderEmail);
    }
}
