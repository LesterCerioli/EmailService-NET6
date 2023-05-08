using Delirio.Modules.Domain.EmailCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Domain.EmailCore.Contracts
{
    public interface IEmailSenderRepository
    {
        Task<OrderEmail> SendEmailAsync(string email, string subject, string message, bool isHtml = false);
    }
}
