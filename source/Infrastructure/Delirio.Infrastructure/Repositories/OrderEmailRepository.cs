using Delirio.Infrastructure.Context;
using Delirio.Modules.Email.Domain.Contracts;
using Delirio.Modules.Email.Domain.Models;
using Delirio.Modules.Email.Domain.Modules;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Infrastructure.Repositories
{
    public class OrderEmailRepository : IOrderEmailRepository
    {

        protected readonly MailDbContext Db;
        protected readonly DbSet<OrderEmail> DbSet;

        public OrderEmailRepository(MailDbContext context)
        {
            Db = context;
            DbSet = context.OrderEmails;
        }

        public async Task Add(OrderEmail orderEmail)
        {
            await Task.Run(() =>
            {
                DbSet.Add(orderEmail);
                Db.SaveChanges();
            });
        }

        public async Task<IEnumerable<OrderEmail>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<OrderEmail> GetByEmail(string email)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Email == email);

        }

        public void Remove(OrderEmail orderEmail)
        {
            DbSet.Remove(orderEmail);
        }

        public void Update(OrderEmail orderEmail)
        {
            DbSet.Update(orderEmail);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
