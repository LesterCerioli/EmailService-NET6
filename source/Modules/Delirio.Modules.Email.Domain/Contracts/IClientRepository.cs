using Delirio.Modules.Email.Domain.Models;
using Delirio.Modules.Email.Domain.ValueObjects;

namespace Delirio.Modules.Email.Domain.Contracts
{
    public interface IClientRepository
    {
        Task<Client> GetByCpf(Cpf cpf);
        
        Task<Client> GetByCustomerFirstName(string customerFirstName);

        Task<Client> GetByMiddleName(string customerMiddleName);

        Task<Client> GetByLastName(string customerLastName);
        
        Task Add(Client client);

        void Remove(Client client);

        void Update(Client client);

    }
}