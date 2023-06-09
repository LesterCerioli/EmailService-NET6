using Delirio.Modules.Email.Application.Servoces.Contracts;
using Delirio.Modules.Email.Domain.Models;
using Microsoft.Extensions.Configuration;
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
            throw new NotImplementedException();
        }
    }
}
