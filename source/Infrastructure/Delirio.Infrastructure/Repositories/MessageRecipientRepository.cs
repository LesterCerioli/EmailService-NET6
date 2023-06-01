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


        public async Task Add(MessageRecipient messageRecipient)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MessageRecipient>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<MessageRecipient> GetByRecipientMail(string recipientMail)
        {
            throw new NotImplementedException();
        }

        public void Remove(MessageRecipient messageRecipient)
        {
            throw new NotImplementedException();
        }

        public void Update(MessageRecipient messageRecipient)
        {
            throw new NotImplementedException();
        }
    }
}
