using ASP_28_12.Domains.EF;
using ASP_28_12.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_28_12.Domains.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            //Data seeding
            modelBuilder.Entity<Customer>().HasData(
                new Customer() { ID = Guid.NewGuid(), Name = "Customer 1", Address = "Hà Nội", PhoneNumber = "0349485127 " },
                new Customer() { ID = Guid.NewGuid(), Name = "Customer 2", Address = "Hà Nội", PhoneNumber = "0349485127 " },
                new Customer() { ID = Guid.NewGuid(), Name = "Customer 3", Address = "Hà Nội", PhoneNumber = "0349485127 " },
                new Customer() { ID = Guid.NewGuid(), Name = "Customer 4", Address = "Hà Nội", PhoneNumber = "0349485127 " } 
                );
            modelBuilder.Entity<Product>().HasData(
                new Product() { ID = Guid.NewGuid(), Name = "Flower 1", Price = 500 },
                new Product() { ID = Guid.NewGuid(), Name = "Flower 2", Price = 600 },
                new Product() { ID = Guid.NewGuid(), Name = "Flower 3", Price = 450 },
                new Product() { ID = Guid.NewGuid(), Name = "Flower 4", Price = 420 }
                );
            modelBuilder.Entity<User>().HasData(
                new User() { Id = Guid.NewGuid(), UserName = "User 1", Address = "Tuyên Quang", PhoneNumber = "0349485127" },
                new User() { Id = Guid.NewGuid(), UserName = "User 2", Address = "Tuyên Quang", PhoneNumber = "0349485127" }
                );
        }
       
    }
}
