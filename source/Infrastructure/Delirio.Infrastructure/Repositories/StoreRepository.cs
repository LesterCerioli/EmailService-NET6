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
    public class StoreRepository : IStoreRepository
    {

        protected readonly MailDbContext Db;
        protected readonly DbSet<Store> DbSet;

        public StoreRepository(MailDbContext context)
        {
            Db = context;
            DbSet = context.Stores;
        }

        public async Task Add(Store store)
        {
            await Task.Run(() =>
            {
                DbSet.Add(store);
                Db.SaveChanges();
            });
        }

        public async Task<IEnumerable<Store>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<Store> GetByCnpj(Cnpj cnpj)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Cnpj == cnpj);
        }

        public async Task<Store> GetByStoreName(string storeName)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.StoreName == storeName);
        }

        public void Remove(Store store)
        {
            throw new NotImplementedException();
        }

        public void Update(Store store)
        {
            throw new NotImplementedException();
        }
    }
}
