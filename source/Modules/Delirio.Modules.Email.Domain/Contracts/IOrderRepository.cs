using Delirio.Modules.Email.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Domain.Contracts
{
    public interface IOrderRepository
    {
        Task<Order> GetByOrderBy(string orderBy);

        Task<Order> GetByOrderDaet(DateTime orderdate);

        Task<IEnumerable<Order>> GetAll();

        Task Add(Order order);

        void Update(Order order);

        void Remove(Order order);
    }
}
