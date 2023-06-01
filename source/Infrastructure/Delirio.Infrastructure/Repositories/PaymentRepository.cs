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
            throw new NotImplementedException();
        }

        public async Task<Payment> GetByAuthorization(string authorizationCode)
        {
            throw new NotImplementedException();
        }

        public async Task<Payment> GetByPaymentOrder(string paymentOrder)
        {
            throw new NotImplementedException();
        }

        public async Task<Payment> GetByPaymentStatus(PaymentStatus paymentStatus)
        {
            throw new NotImplementedException();
        }

        public void Remove(Payment paymentMachine)
        {
            throw new NotImplementedException();
        }

        public void Update(Payment paymentMachine)
        {
            throw new NotImplementedException();
        }
    }
}
