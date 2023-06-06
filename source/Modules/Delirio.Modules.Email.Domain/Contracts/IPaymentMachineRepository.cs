using Delirio.Modules.Email.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Domain.Contracts
{
    public interface IPaymentMachineRepository
    {
        Task<PaymentMachine> GetByIpAddress(string ipAddress);

        Task<PaymentMachine> GetByVisanet(string visanet);

        Task<PaymentMachine> GetByCreditCard(string creditCard);

        Task<IEnumerable<PaymentMachine>> GetAll();

        Task Add(PaymentMachine paymentMachine);

        void Update(PaymentMachine paymentMachine);

        void Remove(PaymentMachine paymentMachine);
    }
}
