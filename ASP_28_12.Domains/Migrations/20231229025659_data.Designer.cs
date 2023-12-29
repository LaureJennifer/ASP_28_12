﻿// <auto-generated />
using System;
using ASP_28_12.Domains.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP_28_12.Domains.Migrations
{
    [DbContext(typeof(FlowerDbContext))]
    [Migration("20231229025659_data")]
    partial class data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASP_28_12.Domains.Entities.Customer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customers", (string)null);

                    b.HasData(
                        new
                        {
                            ID = new Guid("80379a2e-6754-4966-a6be-7054b82eb352"),
                            Address = "Hà Nội",
                            Name = "Customer 1",
                            PhoneNumber = "0349485127 "
                        },
                        new
                        {
                            ID = new Guid("c898b268-6de5-4e98-96ff-359e1a8b4bf3"),
                            Address = "Hà Nội",
                            Name = "Customer 2",
                            PhoneNumber = "0349485127 "
                        },
                        new
                        {
                            ID = new Guid("f8a3ec44-1975-4513-ab6d-8d82cdf42566"),
                            Address = "Hà Nội",
                            Name = "Customer 3",
                            PhoneNumber = "0349485127 "
                        },
                        new
                        {
                            ID = new Guid("c7ce01fc-cbb5-4279-8b86-795fcadac4af"),
                            Address = "Hà Nội",
                            Name = "Customer 4",
                            PhoneNumber = "0349485127 "
                        });
                });

            modelBuilder.Entity("ASP_28_12.Domains.Entities.Order", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("OrderDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValue(new DateTimeOffset(new DateTime(2023, 12, 29, 2, 56, 59, 673, DateTimeKind.Unspecified).AddTicks(8532), new TimeSpan(0, 0, 0, 0, 0)));

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("ASP_28_12.Domains.Entities.OrderDetails", b =>
                {
                    b.Property<Guid>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails", (string)null);
                });

            modelBuilder.Entity("ASP_28_12.Domains.Entities.Product", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            ID = new Guid("5b835afb-0b66-4aea-9804-e511b1cdbf7f"),
                            Name = "Flower 1",
                            Price = 500.0
                        },
                        new
                        {
                            ID = new Guid("4634ff15-3447-4fd2-8ccb-6e5d7f750433"),
                            Name = "Flower 2",
                            Price = 600.0
                        },
                        new
                        {
                            ID = new Guid("4c5ff00a-2929-4f69-99cc-cf41f5cab736"),
                            Name = "Flower 3",
                            Price = 450.0
                        },
                        new
                        {
                            ID = new Guid("efb6a8c8-8ba7-4a68-a100-8ee84737ed96"),
                            Name = "Flower 4",
                            Price = 420.0
                        });
                });

            modelBuilder.Entity("ASP_28_12.Domains.Entities.Order", b =>
                {
                    b.HasOne("ASP_28_12.Domains.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ASP_28_12.Domains.Entities.OrderDetails", b =>
                {
                    b.HasOne("ASP_28_12.Domains.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP_28_12.Domains.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ASP_28_12.Domains.Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ASP_28_12.Domains.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("ASP_28_12.Domains.Entities.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
