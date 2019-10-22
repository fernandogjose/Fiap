using Fiap.Domain.Entities;
using Fiap.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Fiap.Infra.Data.Extensions;
using System.Linq;

namespace Fiap.Infra.Data
{
    public class Context : DbContext
    {
        public DbSet<Receita> Receita { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environmentName}.json", optional: true)
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("SqlConnection"));
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new ReceitaMapping());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCriacao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCriacao").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCriacao").IsModified = false;
                    entry.Property("DataAlteracao").CurrentValue = DateTime.Now;
                }
            }

            // FK State
            foreach (var item in ChangeTracker.Entries())
            {
                String PrimaryKey = item.Entity.GetType().GetProperties().Single(p => p.Name == "Id").Name;

                if (Convert.ToInt32(item.Entity.GetType().GetProperty(PrimaryKey).GetValue(item.Entity)) > 0 && item.State == EntityState.Added)
                {
                    item.State = EntityState.Modified;
                }
            }

            return base.SaveChanges();
        }
    }
}
