using ASP_28_12.Domains.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP_28_12.Domains.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            //Data seeding
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = Guid.Parse("24376e80-b08c-4d9d-88c6-d0f9c9366933"),Name="admin",Description="admin",NormalizedName="ADMIN"},
                new Role { Id = Guid.Parse("24376e80-b08c-4d9d-88c6-d0f9c9366931"), Name = "customer", Description = "customer", NormalizedName = "CUSTOMER" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product() { ID = Guid.NewGuid(), Name = "Flower 1", Price = 500, CreatedDate = DateTimeOffset.UtcNow, UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                new Product() { ID = Guid.NewGuid(), Name = "Flower 2", Price = 600, CreatedDate = DateTimeOffset.Now, UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                new Product() { ID = Guid.NewGuid(), Name = "Flower 3", Price = 450, CreatedDate = DateTimeOffset.UtcNow, UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                new Product() { ID = Guid.NewGuid(), Name = "Flower 4", Price = 420, CreatedDate = DateTimeOffset.Now, UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" }
                );
            modelBuilder.Entity<User>().HasData(
                new User() { Id = Guid.NewGuid(), RoleId= Guid.Parse("24376e80-b08c-4d9d-88c6-d0f9c9366931"), UserName = "User1", Address = "Tuyên Quang", NormalizedUserName="admin1",NormalizedEmail="admin1@gmail.com",SecurityStamp=Guid.NewGuid().ToString(),PhoneNumber = "0349485127", CreatedDate = DateTimeOffset.Now, UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                new User() { Id = Guid.NewGuid(), RoleId = Guid.Parse("24376e80-b08c-4d9d-88c6-d0f9c9366933"), UserName = "User2", Address = "Tuyên Quang", NormalizedUserName = "admin2", NormalizedEmail = "admin2@gmail.com", SecurityStamp = Guid.NewGuid().ToString(), PhoneNumber = "0349485127", CreatedDate = DateTimeOffset.Now, UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                new User() { Id = Guid.NewGuid(), RoleId = Guid.Parse("24376e80-b08c-4d9d-88c6-d0f9c9366931"), UserName = "User3", Address = "Tuyên Quang", PhoneNumber = "0349485127", CreatedDate = DateTimeOffset.Now, UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                new User() { Id = Guid.NewGuid(), RoleId = Guid.Parse("24376e80-b08c-4d9d-88c6-d0f9c9366931"), UserName = "User4", Address = "Tuyên Quang", PhoneNumber = "0349485127", CreatedDate = DateTimeOffset.Now, UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" }
                );
        
        }


    }
}
