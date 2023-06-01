using Delirio.Infrastructure.Context;
using Delirio.Modules.Email.Domain.Contracts;
using Delirio.Modules.Email.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        protected readonly MailDbContext Db;
        protected readonly DbSet<Order> DbSet;

        public OrderRepository(MailDbContext context)
        {
            Db = context;
            DbSet = context.Orders;
        }



        public async Task Add(Order order)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Order> GetByOrderBy(string orderBy)
        {
            throw new NotImplementedException();
        }

        public async Task<Order> GetByOrderDaet(DateTime orderdate)
        {
            throw new NotImplementedException();
        }

        public void Remove(Order order)
        {
            throw new NotImplementedException();
        }

        public void Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
