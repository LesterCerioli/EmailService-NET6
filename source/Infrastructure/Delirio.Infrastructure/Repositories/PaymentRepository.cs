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
    public class PaymentRepository : IPaymentRepository
    {
        protected readonly MailDbContext Db;
        protected readonly DbSet<Payment> DbSet;

        public PaymentRepository(MailDbContext context)
        {
            Db = context;
            DbSet = context.Payments;
        }


        public async Task Add(Payment paymentMachine)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Payment>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<Payment> GetByAuthorization(string authorizationCode)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.AuthorizationCode == authorizationCode);
        }

        public async Task<Payment> GetByPaymentOrder(string paymentOrder)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.PaymentOrder == paymentOrder);
        }

        public async Task<Payment> GetByPaymentStatus(PaymentStatus paymentStatus)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.paymentStatus == paymentStatus);
        }

        public void Remove(Payment payment)
        {
            DbSet.Remove(payment);
        }

        public void Update(Payment payment)
        {
            DbSet.Update(payment);
        }
        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
