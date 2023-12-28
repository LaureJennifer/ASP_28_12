using ASP_28_12.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_28_12.Infrastructure.Configurations
{
    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<OrderDetails> builder)
        {
            builder.ToTable("OrderDetails"); // Đặt tên cho bảng là "OrderDetails"

            builder.HasKey(e => new { e.OrderID, e.ProductID });
            builder.Property(e => e.OrderID).ValueGeneratedOnAdd();
            builder.Property(e => e.ProductID).ValueGeneratedOnAdd();

            builder.Property(od => od.Quantity).IsRequired(); // Yêu cầu trường Quantity không được null

            builder.HasOne(e => e.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(e => e.OrderID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(e => e.ProductID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
