using Delirio.Modules.Email.Domain.ValueObjects;
using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Application.Handlers.Customers
{
    public abstract class CustomerCommand : Command
    {
        public Guid Id { get; protected set; }

        public string? CustomerFirstName { get; protected set; }

        public string? CustomerMiddleName { get; protected set; }

        public string? CustomerLastName { get; protected set; }

        public string? Cpf { get; protected set; }

        public DataLog2 DataLog { get; protected set; }

        public string? Email { get; protected set; }
    }
}
