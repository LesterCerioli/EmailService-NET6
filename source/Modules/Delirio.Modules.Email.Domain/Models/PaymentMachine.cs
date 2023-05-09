using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.Models
{
    public class PaymentMachine : Entity, IAggregateRoot
    {

        public PaymentMachine(Guid id, string visanet)
        {
            Id = id;
            Visanet = visanet;
        }
        public string? Visanet {get; private set;}


        
    }
}