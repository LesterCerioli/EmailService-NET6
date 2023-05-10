using Delirio.Modules.Email.Domain.Models;
using Delirio.Modules.Email.Domain.Modules;
using Microsoft.EntityFrameworkCore;

namespace Delirio.Infrastructure.Context
{
    public class MailDbContext : DbContext
    {
        public MailDbContext(DbContextOptions<MailDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Customer> Customers { get; set; }
        
        public DbSet<MessageQueue> MessageQueues { get; set; }

        public DbSet<MessageRecipient> MssageRecipients {get; set;}

        public DbSet<Order> Orders {get; set;}

        public DbSet<OrderEmail> OrderEmails {get; set;}

        public DbSet<PaymentMachine> PaymentMachines {get; set;}

        public DbSet<Store> Stores {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore<Event>();

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                    e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfiguration(new PacienteMap());
            modelBuilder.ApplyConfiguration(new TokenRequestMap());

            modelBuilder.Entity<Paciente>(c =>
            {
                c.ToTable("Pacientes");
            });

            modelBuilder.Entity<RequestToken>(c =>
            {
                c.ToTable("RequestToken");
            });


            base.OnModelCreating(modelBuilder);
        }
        
    }
}