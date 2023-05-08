using Delirio.Modules.EmailCore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.EmailCore.Domain.Contracts
{
    public interface IEmailSenderRepository
    {
        Task<OrderEmail> SendEmailAsync(string email, string subject, string message, bool isHtml = false);

    }
}
