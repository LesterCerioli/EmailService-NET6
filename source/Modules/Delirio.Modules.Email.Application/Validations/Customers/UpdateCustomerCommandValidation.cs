using Delirio.Modules.Email.Application.Handlers.Customers;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Application.Validations.Customers
{
    public class UpdateCustomerCommandValidation : CustomerValidation<UpdateCustomerCommand>
    {
        internal ValidationResult Validate(UpdateCustomerCommand updateCustomerCommand)
        {
            throw new NotImplementedException();
        }
    }
}
