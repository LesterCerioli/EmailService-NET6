using Delirio.Modules.Email.Application.Servoces.Contracts;
using Delirio.Modules.Email.Application.Servoces.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Workers.Email
{
    public class EmailWorker : BackgroundService
    {
        private readonly IEmailAppService _emailAppService;

        public EmailWorker(IEmailAppService emailAppService)
        {
            _emailAppService = emailAppService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {

            }
        }
    }
}
