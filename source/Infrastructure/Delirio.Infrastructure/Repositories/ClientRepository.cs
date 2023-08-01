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
    public class ClientRepository : IClientRepository
    {
        protected readonly MailDbContext Db;
        protected readonly DbSet<Client> DbSet;

        public ClientRepository(MailDbContext context)
        {
            Db = context;
            DbSet = context.Clients;
        }



        public async Task<IEnumerable<Client>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task Add(Client client)
        {
            await Task.Run(() =>
            {
                DbSet.Add(client);
                Db.SaveChanges();
            });


        }

        public async Task<Client> GetByCpf(Cpf cpf)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Cpf.CPFNumber == cpf.CPFNumber);
        }

        public async Task<Client> GetByLastName(string customerLastName)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.CustomerLastName == customerLastName);
        }

        public async Task<Client> GetByMiddleName(string customerMiddleName)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.CustomerMiddleName == customerMiddleName);
        }


        public async Task<Client> GetByCustomerFirstName(string customerFirstName)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.CustomerFirstName == customerFirstName);
        }

        public void Remove(Client client)
        {
            DbSet.Remove(client);
        }

        public void Update(Client client)
        {
            DbSet.Update(client);
        }

        public void Dispose()
        {
            Db.Dispose();
        }






    }
}
