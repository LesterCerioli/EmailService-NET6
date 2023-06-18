using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Domain.Models
{
    public class EmailConfig
    {
        public EmailConfig(string smtpServer, int smtpPort, 
            string smtpUsername, string smtpPassword)
        {
            SmtpServer = smtpServer;
            SmtpPort = smtpPort;
            SmtpUsername = smtpUsername;
            SmtpPassword = smtpPassword;
        }

        public string SmtpServer { get; set; }
        
        public int SmtpPort { get; set; }
        
        public string SmtpUsername { get; set; }
        
        public string SmtpPassword { get; set; }
    }
}
