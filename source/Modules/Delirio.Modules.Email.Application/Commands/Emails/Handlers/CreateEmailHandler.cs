using Delirio.Modules.Email.Application.Commands.Emails.Requests;
using Delirio.Modules.Email.Application.Commands.Emails.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Application.Commands.Emails.Handlers
{
    public class CreateEmailHandler : ICreateEmailHandler
    {
        public CreateEmailResponse Handle(CreateEmailRequest request)
        {

            return new CreateEmailResponse
            {

            };

        }
    }
}
