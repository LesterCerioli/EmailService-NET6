using Delirio.Modules.Email.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Domain.Contracts
{
    public interface IMessageRecipient
    {
        Task<MessageRecipient> GetByRecipientMail(string recipientMail);

        Task<IEnumerable<MessageRecipient>> GetAll();

        Task Add(MessageRecipient messageRecipient);

        void Update(MessageRecipient messageRecipient);

        void Remove(MessageRecipient messageRecipient);
    }
}
