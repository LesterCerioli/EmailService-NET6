using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Domain.Models
{
    public class RecipientMessage
    {
        //Destinatário da Mensagem
        
        private readonly List<MessageQueue> _messageQueues;

        public RecipientMessage(string email)
        {
            _messageQueues = new List<MessageQueue>();
            Email = email;
        }


        [MaxLength(300)]
        public string? Email { get; private set; }

        public MessageQueue MessageQueue { get; private set; }

        public IReadOnlyCollection<MessageQueue> MessageQueues { get { return _messageQueues.ToArray(); } }
    }
}
