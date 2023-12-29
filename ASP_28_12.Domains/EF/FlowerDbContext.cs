using ASP_28_12.Domains.Configurations;
using ASP_28_12.Domains.Entities;
using ASP_28_12.Domains.Extensions;
using Microsoft.EntityFrameworkCore;

namespace ASP_28_12.Domains.EF
{
    public class FlowerDbContext : DbContext
    {
        public FlowerDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailsConfiguration());

            modelBuilder.Seed();
        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

    }
}
