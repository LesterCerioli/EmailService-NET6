using Delirio.Modules.Email.Domain.ValueObjects;
using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.Models
{
    public class Client : Entity, IAggregateRoot
    {
        private readonly List<Order> _orders = new List<Order>();

        public Client(string? customerFirstName, 
            string? customerMiddleName, string? customerLastName, 
            Cpf cpf, DataLog2 dataLog, string? email)
        {
            CustomerFirstName = customerFirstName;
            CustomerMiddleName = customerMiddleName;
            CustomerLastName = customerLastName;
            Cpf = cpf;
            DataLog = dataLog;
            Email = email;
            _orders = new List<Order>();
        }

        public Client() { }

        public string?  CustomerFirstName { get; set; }

        public string? CustomerMiddleName { get; set; }

        public string? CustomerLastName { get; set; }

        public Cpf  Cpf { get; private set; }
        
        public DataLog2 DataLog { get; private set; }

        public string? Email { get; private set; }

        public IReadOnlyCollection<Order> Orders => _orders.AsReadOnly();

        

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