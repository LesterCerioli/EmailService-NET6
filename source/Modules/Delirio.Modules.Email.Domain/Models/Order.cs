using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.Models
{
    public class Order : Entity, IAggregateRoot
    {
        private IList<Store> _stores;
        
        private IList<Client> _clients;
        
        public Order()
        {
            Id = Id;
            _stores = new List<Store>();
            _clients = new List<Client>();
            

        }
        
        public string? OrderBy { get; private set; }

        public decimal TotalValue { get; private set; }

        
        
        public Client Client { get; private set; }

        public Store Store { get; private set; }

        public Guid CustomerId { get; set; }

        public Guid StoreId { get; set; }




        public IReadOnlyCollection<Client> Clients { get { return _clients.ToArray(); } }
        
        public DateTime OrderDate { get; private set; }

        public IReadOnlyCollection<Store> Stores { get { return _stores.ToArray(); } }
        
    }
}