using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LedgerApplication.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // Use a working dev connection string here.
            // If you hit SSL errors against a remote server, use TrustServerCertificate=True for dev:
            // "Server=yourserver;Database=LedgerAppDb;User Id=USER;Password=PASS;Encrypt=True;TrustServerCertificate=True;"
            var connectionString = "Server=.;Database=LedgerAppDb;Trusted_Connection=True;Encrypt=False";

            optionsBuilder.UseSqlServer(connectionString);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}