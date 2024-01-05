using Delirio.Workers.Email;
using Delirio.Workers.Email.Jobs;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddHostedService<EmailServiceWorker>();
    })
    .Build();

await host.RunAsync();
