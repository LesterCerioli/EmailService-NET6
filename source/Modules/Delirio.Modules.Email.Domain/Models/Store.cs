using Delirio.Modules.Email.Domain.ValueObjects;
using NetDevPack.Domain;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Delirio.Modules.Email.Domain.Models
{
    public class Store : Entity, IAggregateRoot
    {

        private readonly List<PaymentMachine> _paymentMachines = new List<PaymentMachine>();

        public Store(Guid id, string storeName)
        {
            Id = id;
            StoreName = storeName;
        }

        public string? StoreName { get; private set; }

        public string? ManagerName { get; private set; }

        public Address Address { get; private set; }

        public string? SocialReason { get; private set; }

        public PaymentMachine PaymentMachines { get; private set; }

        public Telephone Telephone { get; private set; }

        public IReadOnlyCollection<PaymentMachine> PaymentMchines => _paymentMachines.AsReadOnly();

        public string? District { get; private set; }

        public Cnpj Cnpj { get; private set; }

        [MaxLength(300)]
        public string? StoreEmail { get; private set; }

        [MaxLength(300)]
        public string? StoreEmailCopy { get; private set; }

        [MaxLength(30)]
        public string? Visanet { get; private set; }

        public DateTimeOffset? CreationDate { get; private set; }

        public DateTimeOffset? DeletionDate { get; private set; }

        //Open on Saturady
        // Funciona Sábado
        public int OpenSaturday { get; private set; }

        //Open on Sunday
        //Funciona no Domingo
        public int OpenOnSunday { get; private set; }

        [Required(ErrorMessage = "Preenchimento Obrigatório")]
        [MaxLength(30)]
        public string? CieloNumber { get; private set; }


        [Required(ErrorMessage = "Preenchimento Obrigatório")]
        [MaxLength(100)]
        public string? CieloKey { get; private set; }

        public decimal Latitude { get; private set; }

        public decimal Longitude { get; private set; }

        
        //Aberto todos os dias
        //Opened EveryDays
        public bool OpenedEveryDay { get; private set; }

        //Opened on Monday until Saturday
        //Aberto de Segunda à Sábado
        public bool OpenedMondayToSaturday { get; private set; }

        [MaxLength(200)]
        public string? HolidayText { get; private set; }






    }
}