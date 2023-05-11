using Delirio.Modules.Email.Domain.ValueObjects;
using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.Models
{
    public class Order : Entity, IAggregateRoot
    {
        private IList<Store> _stores;
        
        private IList<Customer> _customers;
        
        public Order()
        {
            Id = Id;
            _stores = new List<Store>();
            _customers = new List<Customer>();
            

        }
        
        public string? OrderBy { get; private set; }

        public decimal TotalValue { get; private set; }
                
        public Customer Customer { get; private set; }

        public Store Store { get; private set; }

        public IReadOnlyCollection<Customer> Customers { get { return _customers.ToArray(); } }
        
        public DateTime? OrderDate { get; set; }

        public IReadOnlyCollection<Store> Stores { get { return _stores.ToArray(); } }

        //Data Retirada
        public DateTimeOffset? PickUpDate {get; private set;}

        public DateTimeOffset? PaymentIndicDate { get; private set; }

        public DataLog DataLog {get; private set;}

        public string? IndicNatalNormalReveia { get; private set; }

        // Bandeira de Cartao Credito
        // Credit Card Flag
        public string? Flag { get; private set; }

        // Indica email enviado
        // Indicate sent email
        public bool SentEmail { get; private set; }

        public string? MyProperty { get; private set; }

        public Telephone Telephone { get; private set; }
        
    }
}