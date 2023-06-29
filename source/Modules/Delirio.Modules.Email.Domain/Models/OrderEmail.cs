using Delirio.Modules.Email.Domain.Models;
using NetDevPack.Domain;
using System.ComponentModel.DataAnnotations;

namespace Delirio.Modules.Email.Domain.Modules
{
    public class OrderEmail : Entity, IAggregateRoot
    {
        
        //Email Encomendas
        private readonly List<Store> _stores;

        public OrderEmail()
        {
            _stores = new List<Store>();
        }


        [MaxLength(200)]
        public string? Email { get; private set; }

        public Store Store { get; private set; }

        public IReadOnlyCollection<Store> Stores { get { return _stores.ToArray(); } }

        public Guid StoreId { get; set; }

    }
}