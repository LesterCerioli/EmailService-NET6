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
    public class MessageRecipientRepository : IMessageRecipient
    {
        protected readonly MailDbContext Db;
        protected readonly DbSet<MessageRecipient> DbSet;

        public MessageRecipientRepository(MailDbContext context)
        {
            Db = context;
            DbSet = context.MssageRecipients;
        }


        public async Task<MessageRecipient> GetByRecipientMail(string recipientMail)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.RecipientMail == recipientMail);
        }

        public async Task Add(MessageRecipient messageRecipient)
        {
            await Task.Run(() =>
            {
                DbSet.Add(messageRecipient);
                Db.SaveChanges();
            });
        }

        public async Task<IEnumerable<MessageRecipient>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        

        public void Remove(MessageRecipient messageRecipient)
        {
            DbSet.Remove(messageRecipient);
        }

        public void Update(MessageRecipient messageRecipient)
        {
            DbSet.Update(messageRecipient);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
