﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Application.Commands.Emails.Requests
{
    public class CreateEmailRequest
    {
        public string? Email { get; set; }

        public string? Recipient { get; set; }

        public string? Subject { get; set; }

        public string? Body { get; set; }
    }
}
