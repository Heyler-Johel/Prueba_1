using Prueba_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Prueba_1.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Bill>().ToTable("Bill");
            modelBuilder.Entity<Transfer>().ToTable("Transfer");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}