using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delirio.Modules.Email.Domain.ValueObjects;
using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.Models
{
    public class PaymentMachine : Entity, IAggregateRoot
    {
        private readonly List<Payment> _payments = new List<Payment>();
        
        public IReadOnlyCollection<Payment> Payments => _payments;

        private readonly List<Order> _orders;
        public readonly object StoreId;

        public PaymentMachine(Guid id, string visanet, string creditCard, string ipAddress)
        {
            Id = id;
            Visanet = visanet;
            _payments = new List<Payment>();
            CreditCard = CreditCard;
            IpAddress = ipAddress;
            
        }
        public PaymentMachine() {}

        public string? IpAddress { get; private set; }

        public Store Store { get; set; }

        [MaxLength(30)]
        public string? Visanet {get; private set;}
        [Required(ErrorMessage = "O NÚMERO DP CARTÃO deve ser informado")]

        
        public Address Address { get; private set; }

        public int Amount { get; private set; }

        [MaxLength(15)]
        public string? CreditCard { get; private set; }

        [MaxLength(300)]
        public string? CodeAuthorization { get; private set; }

        

        public Guid PaymentId { get; set; }

               

        public void AddPayment(Payment payment)
        {
            _payments.Add(payment);
        }
    }
}
