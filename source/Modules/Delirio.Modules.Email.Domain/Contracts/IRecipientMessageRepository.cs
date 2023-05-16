using Delirio.Modules.Email.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Domain.Contracts
{
    public interface IRecipientMessageRepository
    {
        Task<RecipientMessage> GetByEmail(string email);

        Task<IEnumerable<RecipientMessage>> GetAll();

        Task Add(RecipientMessage recipientMessage);

        void Update(RecipientMessage recipientMessage);

        void Remove(RecipientMessage recipientMessage);
    }
}
