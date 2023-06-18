using Delirio.Modules.Email.Application.Servoces.Contracts;
using Delirio.Modules.Email.Domain.Models;
using MailKit.Security;
using MimeKit;
using NetDevPack.Messaging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Net.Mail;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Application.Servoces.Implementations
{
    public class EmailAppService : IEmailAppService
    {
        private readonly string smtpServer;
        private readonly int smtpPort;
        private readonly string smtpUsername;
        private readonly string smtpPassword;

        public EmailAppService()
        {
            var configPath = "appsetting.json";
            var configJson = File.ReadAllText(configPath);
            var config = JsonConvert.DeserializeObject<EmailConfig>(configJson);

            smtpServer = config.SmtpServer;
            smtpPort = config.SmtpPort;
            smtpUsername = config.SmtpUsername;
            smtpPassword = config.SmtpPassword;
        }
        
        public async Task SendOrderConfirmationEmail(string recipientEmail, string orderNumber, decimal orderAmount, string deliveryAddress, string paymentStatus)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Encomendas", smtpUsername));
                message.To.Add(new MailboxAddress("", recipientEmail));
                message.Subject = "Detalhes da encomenda";

                var builder = new BodyBuilder();
                builder.TextBody = $"Detalhes de pagamento: {paymentDetails}\n" +
                                   $"Valor: {amount}\n" +
                                   $"Forma de pagamento: {paymentMethod}\n" +
                                   $"Status de pagamento: {paymentStatus}\n" +
                                   $"Endereço de entrega: {deliveryAddress}";

                message.Body = builder.ToMessageBody();

                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true; // Ignorar validação do certificado SSL/TLS

                    await client.ConnectAsync(smtpServer, smtpPort, SecureSocketOptions.Auto);
                    await client.AuthenticateAsync(smtpUsername, smtpPassword);
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }

                Console.WriteLine("E-mail enviado com sucesso!");
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro ao enviar o e-mail" + ex.Message);

                // Tentar reenviar o e-mail com prioridade alta
                //Try to resend the email with high priority
                try
                {
                    message.Priority = MessagePriority.Urgent;

                    using (var client = new SmtpClient())
                    {
                        client.ServerCertificateValidationCallback = (s, c, h, e) => true; // Ignorar validação do certificado SSL/TLS

                        await client.ConnectAsync(smtpServer, smtpPort, SecureSocketOptions.Auto);
                        await client.AuthenticateAsync(smtpUsername, smtpPassword);
                        await client.SendAsync(message);
                        await client.DisconnectAsync(true);
                    }

                    Console.WriteLine("E-mail reenviado com prioridade alta!");
                }

                catch (Exception innerEx)
                {
                    Console.WriteLine("Falha ao reenviar o e-mail com prioridade alta: " + innerEx.Message);
                }
            }
        }
    }
}
