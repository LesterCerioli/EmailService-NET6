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
            await Task.Run(() =>
            {
                DbSet.Add(messageQueue);
                Db.SaveChanges();
            });
        }

        public async Task<MessageQueue> GetBySendingDate(DateTimeOffset? sendingDate)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.SendingDate == sendingDate);
        }

        

        public async Task<MessageQueue> GetByShotsNumber(string shotsNumber)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.ShotsNumber == shotsNumber);
        }

        public async Task<MessageQueue> GetByTitle(string title)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Title == title); ;
        }

        public void Remove(MessageQueue messageQueue)
        {
            DbSet.Remove(messageQueue);
        }

        public void Update(MessageQueue messageQueue)
        {
            DbSet.Update(messageQueue);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
