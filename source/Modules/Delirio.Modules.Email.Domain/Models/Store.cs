using Delirio.Modules.Email.Domain.ValueObjects;
using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.Models
{
    public class Store : Entity, IAggregateRoot
    {
        
        private readonly List<Payment> _paymentMachines = new List<Payment>();
        
        public Store(Guid id, string storeName)
        {
            Id = id;
            StoreName = storeName;
        }
        
        public string? StoreName {get; private set;}

        public string? ManagerName {get; private set;}

        public string? Address {get; private set;}

        public string? SocialReason {get; private set;}

        public Payment PaymentMachines {get; private set;}
        
        public IReadOnlyCollection<Payment> PaymentMchines => _paymentMachines.AsReadOnly();

        public string? District {get; private set;}

        public Cnpj Cnpj {get; private set;}

        


        
    }
}