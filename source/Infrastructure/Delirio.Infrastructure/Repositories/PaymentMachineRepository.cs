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
    public class PaymentMachineRepository : IPaymentMachineRepository
    {
        protected readonly MailDbContext Db;
        protected readonly DbSet<PaymentMachine> DbSet;

        public PaymentMachineRepository(MailDbContext context)
        {
            Db = context;
            DbSet = context.PaymentMachines;
        }

        

        public async Task Add(PaymentMachine paymentMachine)
        {
            await Task.Run(() =>
            {
                DbSet.Add(paymentMachine);
                Db.SaveChanges();

            });
        }

        public async Task<IEnumerable<PaymentMachine>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<PaymentMachine> GetByCreditCard(string creditCard)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.CreditCard == creditCard);
        }

        public async Task<PaymentMachine> GetByIpAddress(string ipAddress)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.IpAddress == ipAddress);
        }

        public async Task<PaymentMachine> GetByVisanet(string visanet)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Visanet == visanet);
        }

        public void Remove(PaymentMachine paymentMachine)
        {
            DbSet.Remove(paymentMachine);
        }

        public void Update(PaymentMachine paymentMachine)
        {
            DbSet.Update(paymentMachine);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
