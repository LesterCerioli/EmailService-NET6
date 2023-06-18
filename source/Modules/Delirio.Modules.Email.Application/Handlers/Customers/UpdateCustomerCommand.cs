using Delirio.Modules.Email.Application.Validations.Customers;
using Delirio.Modules.Email.Domain.ValueObjects;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Application.Handlers.Customers
{
    public class UpdateCustomerCommand : CustomerCommand
    {
        public UpdateCustomerCommand(Guid id, string? customerFirstName, string? customerMiddleName, string? customerLastName, string? cpf, DataLog2 dataLog, string? email)
        {
            Id = id;
            CustomerFirstName = customerFirstName;
            CustomerMiddleName = customerMiddleName;
            CustomerLastName = customerLastName;
            Cpf = cpf;
            DataLog = dataLog;
            Email = email;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateCustomerCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
