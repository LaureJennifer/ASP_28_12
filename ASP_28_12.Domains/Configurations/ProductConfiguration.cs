using ASP_28_12.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASP_28_12.Domains.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products"); // Đặt tên cho bảng là "Products"

            builder.HasKey(p => p.ID); // Đặt trường ID làm khóa chính
            builder.Property(c => c.ID).ValueGeneratedOnAdd();

            builder.Property(p => p.Name).IsRequired(); // Yêu cầu trường Name không được null
            builder.Property(p => p.CreatedDate).HasDefaultValue(DateTimeOffset.UtcNow);

            builder.Property(p => p.Price).IsRequired(); // Yêu cầu trường Price không được null
        }
    }
}
