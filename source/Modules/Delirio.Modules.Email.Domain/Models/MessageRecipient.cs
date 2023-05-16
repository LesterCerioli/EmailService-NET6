using NetDevPack.Domain;
using System.ComponentModel.DataAnnotations;

namespace Delirio.Modules.Email.Domain.Models
{
    public class MessageRecipient : Entity, IAggregateRoot
    {
        // Destinatário mensagem
        // Message Recipient

        private readonly List<MessageQueue> _messageQueues;

        public MessageRecipient(Guid id, string recipientMail)
        {
            Id = id;
            RecipientMail = recipientMail;
            _messageQueues = new List<MessageQueue>();
        }


        [MaxLength(200)]
        public string? RecipientMail {get; private set;}

        

        public IReadOnlyCollection<MessageQueue> MessageQueues { get { return _messageQueues.ToArray(); } }



    }
}