using NetDevPack.Domain;
using System.ComponentModel.DataAnnotations;

namespace Delirio.Modules.Email.Domain.Models
{
    public class MessageQueue : Entity, IAggregateRoot
    {

        private IList<Order> _orders;

        public MessageQueue(Guid id, Order order)
        {
            Id = id;
            _orders = new List<Order>();
            SendingDate = DateTime.Now;
            CreationDate = DateTime.Now;
            LastShotsDate = DateTime.Now;
        }


        //Remetente
        public string? Sender { get; private set; }

        [MaxLength(300)]
        public string? Title {get; private set;}

        public string? Body { get; private set; }

        
        //Data Envio
        public DateTimeOffset? SendingDate { get; private set; }

        //Número Disparos
        public string? ShotsNumber { get; private set; }

        public string? ErrorName { get; private set; }

        public Order Order {get; private set;}

        public IReadOnlyCollection<Order> Orders { get { return _orders.ToArray(); } }

        public DateTimeOffset? CreationDate { get; private set; }

        public DateTimeOffset?  LastShotsDate { get; private set; }

    }
}