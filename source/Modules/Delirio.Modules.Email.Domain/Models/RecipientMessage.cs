using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Domain.Models
{
    public class RecipientMessage
    {
        private readonly List<MessageQueue> _messageQueues;

        public RecipientMessage(string email)
        {
            _messageQueues = new List<MessageQueue>();
            Email = email;
        }
        
        public string? Email { get; private set; }

        public MessageQueue MessageQueue { get; private set; }

        public IReadOnlyCollection<MessageQueue> MessageQueues { get { return _messageQueues.ToArray(); } }
    }
}
