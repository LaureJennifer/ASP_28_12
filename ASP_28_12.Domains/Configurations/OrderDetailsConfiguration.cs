﻿using ASP_28_12.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASP_28_12.Domains.Configurations
{
    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.ToTable("OrderDetails"); // Đặt tên cho bảng là "OrderDetails"

            builder.HasKey(e => e.OrderDetailsID);
            builder.Property(e => e.OrderDetailsID).ValueGeneratedOnAdd();

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
