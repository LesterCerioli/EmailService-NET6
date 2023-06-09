using Delirio.Modules.Email.Application.Servoces.Contracts;
using Delirio.Modules.Email.Domain.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Application.Servoces.Implementations.Smtp
{
    public class EmailSenderSmtpAppService : IEmailSenderAppService
    {
        private readonly EmailConfig _emailConfig = new EmailConfig();

        public EmailSenderSmtpAppService(IConfiguration config)
        {
            _emailConfig.SmtpServer = config.GetValue<string>("encomendasdelirio2023@outlook.com");
            _emailConfig.SmtpUsername = config.GetValue<string>("encomendasdelirio2023@outlook.com");
            _emailConfig.SmtpPassword = config.GetValue<string>("xaxa#2010x");
            _emailConfig.SmtpPort = config.GetValue<int>("587");
        }

        public async Task SendEmailAsync(string recipient, string subject, string body)
        {
            var message = new MimeMessage();
            message.From.AddMailboxAddress("Delirio Encomendas", _smtpUsername));
            message.ToAdd(new MailboxAddress("", recipient));
            message.Subject = subject;

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = body;

            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_smtpServer, _smtpPort, SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(_smtpUsername, _smtpPassword);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }

        }
    }
}
