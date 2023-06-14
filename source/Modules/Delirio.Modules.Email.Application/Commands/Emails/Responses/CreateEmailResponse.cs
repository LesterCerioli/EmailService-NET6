using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Application.Commands.Emails.Responses
{
    public class CreateEmailResponse
    {
        public Guid Id { get; set; }

        public string? Email { get; set; }

        public string? Recipient { get; set; }

        public string? Subject { get; set; }

        public string? Body { get; set; }
    }
}
