using Delirio.Modules.Email.Application.Servoces.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Application.Servoces.Implementations
{
    public class EmailAppService : IEmailAppService
    {

        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly string _smtpUsername;
        private readonly string _smtpPassword;
        private readonly string _senderEmail;

        public EmailAppService(string smtpServer, int smtpPort, string smtpUsername, string smtpPassword, string senderEmail)
        {
            _smtpServer = "smtp-mail.outlook.com";
            _smtpPort = 587;
            _smtpUsername = "encomendasdelirio2023@outlook.com";
            _smtpPassword = smtpPassword;
            _senderEmail = "encomendasdelirio2023@outlook.com";
        }

        public async Task SendOrderConfirmationEmail(string recipientEmail, string orderNumber, decimal orderAmount, string deliveryAddress, string paymentStatus)
        {
            string subject = "Confirmacao de Pedido";
            string body = $"Número do Pedido: {orderNumber}\n" +
                          $"Valor Total do Pedido: R${orderAmount}\n" +
                          $"Endereço de Entrega: {deliveryAddress}\n" +
                          $"Status de pagamento: {paymentStatus}";

            using (var client = new SmtpClient(_smtpServer, _smtpPort))
            {
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(_smtpUsername, _smtpPassword);
                client.EnableSsl = true;

                using (var message = new MailMessage(_senderEmail, recipientEmail, subject, body))
                {
                    await client.SendMailAsync(message);
                }
            }
        }
    }
}
