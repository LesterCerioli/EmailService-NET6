using Delirio.Modules.Email.Domain.Models;

namespace Delirio.Modules.Email.Domain.Contracts
{
    public interface IMessageQueueRepository
    {
        Task<MessageQueue> GetBySendingDate(DateOnly sendingDate);

        Task<MessageQueue> GetByShotsNumber(string shotsNumber);

        Task<MessageQueue> GetByTitle(string title);

        Task Add(MessageQueue messageQueue);

        void Update(MessageQueue messageQueue);

        void Remove(MessageQueue messageQueue);



    }
}