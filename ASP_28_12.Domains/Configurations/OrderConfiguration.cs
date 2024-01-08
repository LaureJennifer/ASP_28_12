using ASP_28_12.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASP_28_12.Domains.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders"); // Đặt tên cho bảng là "Orders"

            builder.HasKey(o => o.ID); // Đặt trường ID làm khóa chính
            builder.Property(c => c.ID).ValueGeneratedOnAdd();

            builder.Property(o => o.OrderDate).HasDefaultValue(DateTimeOffset.UtcNow).IsRequired();

            builder.Property(o => o.Status).IsRequired(); // Yêu cầu trường Status không được null
            builder.Property(o => o.TotalFee).IsRequired();

            builder.HasOne(e => e.User)
                .WithMany(c => c.Orders)
                .HasForeignKey(e => e.UserID)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
