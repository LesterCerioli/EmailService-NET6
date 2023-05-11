using Delirio.Modules.Email.Domain.ValueObjects;
using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.Models
{
    public class Customer : Entity, IAggregateRoot
    {
        private readonly List<Order> _orders = new List<Order>();

        public Customer(Guid id, Cpf cpf)
        {
            Id = id;
            _orders = new List<Order>();
            Cpf = cpf;

        }
        
        public string?  CustomerName { get; set; }

        public Cpf  Cpf { get; private set; }
        
        public DataLog DataLog { get; private set; }

        public IReadOnlyCollection<Order> Orders => _orders.AsReadOnly();

        public string? Email { get; private set; }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public void RemoveOrder(Order order)
        {
            _orders.Remove(order);
        }
        
    }
}