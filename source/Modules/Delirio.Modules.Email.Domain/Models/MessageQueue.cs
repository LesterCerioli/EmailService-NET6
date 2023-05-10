using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.Models
{
    public class MessageQueue : Entity, IAggregateRoot
    {

        private IList<Order> _orders;

        public MessageQueue(Guid id, Order order)
        {
            Id = id;
            _orders = new List<Order>();
        }
       
        
        public string? Title {get; private set;}

        public string? Body { get; private set; }

        public DateTimeOffset? SendingDate { get; private set; }

        public string? ShotsNumber { get; private set; }

        public string? ErrorName { get; private set; }

        public Order Order {get; private set;}

        public IReadOnlyCollection<Order> Orders { get { return _orders.ToArray(); } }
        
    }
}