using ASP_28_12.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_28_12.Domains.EF
{
    public class FlowerDbContext : DbContext
    {
        public FlowerDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

    }
}
