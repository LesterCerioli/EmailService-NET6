using Delirio.Infrastructure.Context;
using Delirio.Modules.Email.Domain.Contracts;
using Delirio.Modules.Email.Domain.Models;
using Delirio.Modules.Email.Domain.Modules;
using Delirio.Modules.Email.Domain.ValueObjects;
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
            await Task.Run(() =>
            {
                DbSet.Add(order);
                Db.SaveChanges();
            });
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<Order> GetByOrderBy(string orderBy)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.OrderBy == orderBy);
        }

        public async Task<Order> GetByOrderDaet(DateTime orderdate)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.OrderDate == orderdate);
        }

        

        public void Remove(Order order)
        {
            DbSet.Remove(order);
        }

        public void Update(Order order)
        {
            DbSet.Update(order);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
