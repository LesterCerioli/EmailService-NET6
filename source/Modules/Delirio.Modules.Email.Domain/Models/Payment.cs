using NetDevPack.Domain;
using System.ComponentModel.DataAnnotations;

namespace Delirio.Modules.Email.Domain.Models
{
    public class Payment : Entity, IAggregateRoot
    {

        private readonly List<Order> _orders;

        public Payment(Guid id, string authorizationCode)
        {
            Id = id;
            AuthorizationCode = authorizationCode;
            _orders = new List<Order>();
        }

        [MaxLength(300)]
        public string? AuthorizationCode {get; private set;}

        [MaxLength(50)]
        public string? PaymentOrder { get; private set; }


        [MaxLength(15)]
        public string? CreditCard { get; private set; }

        public PaymentStatus paymentStatus { get; private set; }

        public Order Order { get; private set; }

        public IReadOnlyCollection<Order> Orders { get { return _orders.ToArray(); } }


    }
}