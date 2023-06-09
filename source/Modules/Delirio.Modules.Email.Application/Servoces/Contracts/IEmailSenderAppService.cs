using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Application.Servoces.Contracts
{
    public interface IEmailSenderAppService
    {
        Task SendEmailAsync(string recipient, string subject, string body);
    }
}
