
using Delirio.Modules.Email.Application.Servoces.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Delirio.Workers.Email.Jobs
{
	public class EmailServiceWorker : BackgroundService
	{
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<EmailServiceWorker> _logger;
        private readonly TimeSpan _interval = TimeSpan.FromMilliseconds(5000); // Intervalo de 5 milissegundos

        public EmailServiceWorker(IServiceProvider serviceProvider, ILogger<EmailServiceWorker> logger)
		{
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using (var scope = _serviceProvider.CreateScope())
                    {
                        var emailService = scope.ServiceProvider.GetRequiredService<IEmailAppService>();

                        // Aqui você deve chamar o método para enviar emails
                        // emailService.SendOrderConfirmationEmail(...);

                        _logger.LogInformation("Email enviado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Erro ao enviar email. Tentando novamente em breve...");
                }

                await Task.Delay(_interval, stoppingToken);

            }

        }
	}
}