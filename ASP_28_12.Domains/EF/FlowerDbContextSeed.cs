using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ASP_28_12.Domains.EF
{
    public class FlowerDbContextSeed : IDesignTimeDbContextFactory<FlowerDbContext>
    {
        public FlowerDbContext CreateDbContext(string[] args)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ConnectionString");

            var optionsBuilder = new DbContextOptionsBuilder<FlowerDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new FlowerDbContext(optionsBuilder.Options);

        }

    }
}
