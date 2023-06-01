using Delirio.Modules.Email.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Domain.Contracts
{
    public interface IPaymentRepository
    {
        Task<Payment> GetByAuthorization(string authorizationCode);

        Task<Payment> GetByPaymentOrder(string paymentOrder);

        Task<Payment> GetByPaymentStatus(PaymentStatus paymentStatus);


        Task<IEnumerable<Payment>> GetAll();

        Task Add(Payment payment);

        void Update(Payment payment);

        void Remove(Payment payment);
    }
}
