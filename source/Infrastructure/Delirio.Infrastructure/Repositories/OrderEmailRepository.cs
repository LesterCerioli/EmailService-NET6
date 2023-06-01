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
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OrderEmail>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<OrderEmail> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void Remove(OrderEmail orderEmail)
        {
            throw new NotImplementedException();
        }

        public void Update(OrderEmail orderEmail)
        {
            throw new NotImplementedException();
        }
    }
}
