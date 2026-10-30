using Microsoft.EntityFrameworkCore;
using LedgerApplication.Models;

namespace LedgerApplication.Data
{
    public class AppDbContext : DbContext
    {               
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers => Set<Customer>();

        protected override void OnModelCreating(    ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasKey(c => c.Id);
            modelBuilder.Entity<Customer>().Property(c => c.Name).IsRequired().HasMaxLength(150);
        }
    }
}
