using ASP_28_12.Domains.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP_28_12.Domains.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            //Data seeding
            modelBuilder.Entity<Product>().HasData(
                new Product() { ID = Guid.NewGuid(), Name = "Flower 1", Price = 500, CreatedDate = DateTimeOffset.UtcNow, UrlImage= "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                new Product() { ID = Guid.NewGuid(), Name = "Flower 2", Price = 600, CreatedDate = DateTimeOffset.Now, UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                new Product() { ID = Guid.NewGuid(), Name = "Flower 3", Price = 450, CreatedDate = DateTimeOffset.UtcNow, UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                new Product() { ID = Guid.NewGuid(), Name = "Flower 4", Price = 420, CreatedDate = DateTimeOffset.Now, UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" }
                );
            modelBuilder.Entity<User>().HasData(
                new User() { Id = Guid.NewGuid(), UserName = "User 1", Address = "Tuyên Quang", PhoneNumber = "0349485127", CreatedDate = DateTimeOffset.Now, UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                new User() { Id = Guid.NewGuid(), UserName = "User 2", Address = "Tuyên Quang", PhoneNumber = "0349485127", CreatedDate = DateTimeOffset.Now, UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                new User() { Id = Guid.NewGuid(), UserName = "User 3", Address = "Tuyên Quang", PhoneNumber = "0349485127", CreatedDate = DateTimeOffset.Now, UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                new User() { Id = Guid.NewGuid(), UserName = "User 4", Address = "Tuyên Quang", PhoneNumber = "0349485127", CreatedDate = DateTimeOffset.Now, UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" }
                );
        }

    }
}
