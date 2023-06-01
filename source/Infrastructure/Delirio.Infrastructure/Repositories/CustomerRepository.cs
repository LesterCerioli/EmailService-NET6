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

        public async  Task Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> GetByCpf(Cpf cpf)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> GetByCustomerName(string customerName)
        {
            throw new NotImplementedException();
        }

        public void Remove(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
