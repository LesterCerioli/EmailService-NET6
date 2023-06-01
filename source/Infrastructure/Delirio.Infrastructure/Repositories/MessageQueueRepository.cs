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
    public class MessageQueueRepository : IMessageQueueRepository
    {
        protected readonly MailDbContext Db;
        protected readonly DbSet<MessageQueue> DbSet;

        public MessageQueueRepository(MailDbContext context)
        {
            Db = context;
            DbSet = context.MessageQueues;
        }

        public async Task Add(MessageQueue messageQueue)
        {
            throw new NotImplementedException();
        }

        public async Task<MessageQueue> GetBySendingDate(DateTimeOffset? sendingDate)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.SendingDate == sendingDate);
        }

        

        public async Task<MessageQueue> GetByShotsNumber(string shotsNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<MessageQueue> GetByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public void Remove(MessageQueue messageQueue)
        {
            throw new NotImplementedException();
        }

        public void Update(MessageQueue messageQueue)
        {
            throw new NotImplementedException();
        }
    }
}
