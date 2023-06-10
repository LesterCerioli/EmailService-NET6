using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Application.Servoces.Contracts
{
    public interface IEmailAppService
    {
        Task SendOrderConfirmationEmail(string recipientEmail, string orderNumber, decimal orderAmount, string deliveryAddress, string paymentStatus);
    }
}
