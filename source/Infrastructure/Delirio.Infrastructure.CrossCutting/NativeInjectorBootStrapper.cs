using Delirio.Infrastructure.Context;
using Delirio.Infrastructure.Repositories;
using Delirio.Modules.Email.Domain.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Infrastructure.CrossCutting
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Infrastructure
            services.AddScoped<IClientRepository>();
            services.AddScoped<MessageQueueRepository>();
            services.AddScoped<MessageRecipientRepository>();
            services.AddScoped<OrderEmailRepository>();
            services.AddScoped<OrderRepository>();
            services.AddScoped<PaymentRepository>();
            services.AddScoped<PaymentMachineRepository>();
            services.AddScoped<MailDbContext>();

            // Application
            //services.AddScoped<IPacienteService, PacienteService>();

        }
    }
}
