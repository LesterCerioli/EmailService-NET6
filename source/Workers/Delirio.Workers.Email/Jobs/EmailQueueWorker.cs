using Azure.Storage.Queues;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Workers.Email.Jobs
{
    public class EmailQueueWorker : BackgroundService
    {
        private readonly IConfiguration _configuration;
        private readonly QueueClient _queueClient;

        public EmailQueueWorker(IConfiguration configuration)
        {
            _configuration = configuration;
            var connectionString = _configuration["QueueConnectionString"];
            var queueName = _configuration["QueueName"];
            _queueClient = new QueueClient(connectionString, queueName);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToke)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                QueueMessage message = await RetrieveMessageFromQueue();

                if (message != null)
                {

                }
            }
        }
    }
}
