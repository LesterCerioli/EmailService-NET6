using Delirio.Infrastructure.Mappings.EFCore;
using Delirio.Module.Infrastructure.Mappings.EFCore;
using Delirio.Modules.Email.Domain.Models;
using Delirio.Modules.Email.Domain.Modules;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using NetDevPack.Messaging;

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

            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new MessageQueueMap());
            modelBuilder.ApplyConfiguration(new MessageRecipientMap());
            modelBuilder.ApplyConfiguration(new OrderEmailMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new PaymentMachineMap());
            modelBuilder.ApplyConfiguration(new StoreMap());

            modelBuilder.Entity<Customer>(c =>
            {
                c.ToTable("Customers");
            });

            modelBuilder.Entity<MessageQueue>(c =>
            {
                c.ToTable("MessageQueues");
            });

            modelBuilder.Entity<MessageRecipient>(c =>
            {
                c.ToTable("MessageRecipients");
            });

            modelBuilder.Entity<OrderEmail>(c =>
            {
                c.ToTable("OrderEmails");
            });

            modelBuilder.Entity<Order>(c =>
            {
                c.ToTable("Orders");
            });

            modelBuilder.Entity<PaymentMachine>(c =>
            {
                c.ToTable("PaymentMachines");
            });

            modelBuilder.Entity<Store>(c =>
            {
                c.ToTable("Stores");
            });


            base.OnModelCreating(modelBuilder);
        }
        
    }
}