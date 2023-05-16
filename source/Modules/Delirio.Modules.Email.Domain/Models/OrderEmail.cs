using Delirio.Modules.Email.Domain.Models;
using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.Modules
{
    public class OrderEmail : Entity, IAggregateRoot
    {
        private readonly List<Store> _stores;

        public OrderEmail()
        {
            _stores = new List<Store>();
        }
        
        public string? Email { get; private set; }

        public Store Store { get; private set; }

        public IReadOnlyCollection<Store> Stores { get { return _stores.ToArray(); } }

    }
}