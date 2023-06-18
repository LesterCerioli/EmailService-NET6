using Delirio.Infrastructure.Context;
using Delirio.Modules.Email.Domain.Contracts;
using Delirio.Modules.Email.Domain.Models;
using Delirio.Modules.Email.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        protected readonly MailDbContext Db;
        protected readonly DbSet<Customer> DbSet;

        public CustomerRepository(MailDbContext context)
        {
            Db = context;
            DbSet = context.Customers;
        }



        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task Add(Customer customer)
        {
            await Task.Run(() =>
            {
                DbSet.Add(customer);
                Db.SaveChanges();
            });


        }

        public async Task<Customer> GetByCpf(Cpf cpf)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Cpf.CpfNumber == cpf.CpfNumber);
        }

        public async Task<Customer> GetByLastName(string customerLastName)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.CustomerLastName == customerLastName);
        }

        public async Task<Customer> GetByMiddleName(string customerMiddleName)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.CustomerMiddleName == customerMiddleName);
        }


        public async Task<Customer> GetByCustomerFirstName(string customerFirstName)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.CustomerFirstName == customerFirstName);
        }

        public void Remove(Customer customer)
        {
            DbSet.Remove(customer);
        }

        public void Update(Customer customer)
        {
            DbSet.Update(customer);
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public Task<Customer> GetByEmail(string customerEmail)
        {
            throw new NotImplementedException();
        }
    }
}
