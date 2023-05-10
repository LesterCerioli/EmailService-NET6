using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.Models
{
    public class MessageRecipient : Entity, IAggregateRoot
    {
        // Destinatário mensagem
        // Message Recipient

        public MessageRecipient(Guid id, string recipientMail)
        {
            Id = id;
            RecipientMail = recipientMail;
        }
        
        public string? RecipientMail {get; private set;}


        
    }
}