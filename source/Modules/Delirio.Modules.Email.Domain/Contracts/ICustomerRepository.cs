using Delirio.Modules.Email.Domain.Models;
using Delirio.Modules.Email.Domain.ValueObjects;

namespace Delirio.Modules.Email.Domain.Contracts
{
    public interface ICustomerRepository
    {
        Task<Customer> GetByCpf(Cpf cpf);
        
        Task<Customer> GetByCustomerName(string customerName);

        Task Add(Customer customer);

        void Remove(Customer customer);

        void Update(Customer customer);

    }
}