using System.Security.Cryptography.X509Certificates;
using Delirio.Modules.Email.Domain.Models;
using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.Modules
{
    public class OrderEmail : Entity, IAggregateRoot
    {
        private readonly List<Store> _stores = new List<Store>();
        
        public OrderEmail(StoreLocation store)
        {
            _stores = new List<Store>();
        }
        
        public string? Email { get; private set; }

        public IReadOnlyCollection<Store> Stores => _stores.AsReadOnly();

    }
}