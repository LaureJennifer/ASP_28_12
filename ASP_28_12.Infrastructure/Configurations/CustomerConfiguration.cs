﻿using ASP_28_12.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_28_12.Infrastructure.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers"); // Đặt tên cho bảng là "Customers"

            builder.HasKey(c => c.ID); // Đặt trường ID làm khóa chính
            builder.Property(c => c.ID).ValueGeneratedOnAdd();

            builder.Property(c => c.Name).IsRequired(); // Yêu cầu trường Name không được null
            
            builder.Property(c => c.Address).IsRequired();

            builder.Property(c => c.PhoneNumber).IsRequired();
        }
    }
}
