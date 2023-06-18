using Delirio.Modules.Email.Application.Handlers.Customers;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Application.Validations.Customers
{
    public abstract class CustomerValidation<T> : AbstractValidator<T> where T : CustomerCommand
    {
    }
}
