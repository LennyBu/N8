using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using N8_Data.Entities;
using N8_Data.Repositories.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Data.Repositories
{
    public class N8Context : DbContext
    {
        public static IConfigurationRoot configuration = null!;
        bool testMode = false;

        public DbSet<Event> Events { get; set; } = null!;
        public DbSet<Login> Logins { get; set; } = null!;
        public DbSet<Sponsor> Sponsors { get; set; } = null!;
        public DbSet<Ticket> Tickets { get; set; } = null!;

        public N8Context() { }

        public N8Context(DbContextOptions<N8Context> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)!.FullName)
                    .AddJsonFile("appsettings.json", false)
                .Build();

                var connectionString = configuration.GetConnectionString("n8db");


                optionsBuilder.UseSqlServer(connectionString, options => options.MaxBatchSize(150))

                .LogTo(Console.WriteLine
                    , new[] { DbLoggerCategory.Database.Command.Name }
                    , Microsoft.Extensions.Logging.LogLevel.Information
                    , Microsoft.EntityFrameworkCore.Diagnostics.DbContextLoggerOptions.Level | Microsoft.EntityFrameworkCore.Diagnostics.DbContextLoggerOptions.LocalTime)
                    .EnableSensitiveDataLogging(true)
                    .UseLazyLoadingProxies();
            }
            else
            {
                testMode = true;
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LoginConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            modelBuilder.ApplyConfiguration(new SponsorConfiguration());
            modelBuilder.ApplyConfiguration(new EventConfiguration());
        }
    }
}

