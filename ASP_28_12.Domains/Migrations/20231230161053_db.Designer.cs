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
    [Migration("20231230161053_db")]
    partial class db
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
                        .HasDefaultValue(new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 456, DateTimeKind.Unspecified).AddTicks(8028), new TimeSpan(0, 0, 0, 0, 0)));

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TotalFee")
                        .HasColumnType("int");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("UserID");

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

                    b.Property<DateTimeOffset>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValue(new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 456, DateTimeKind.Unspecified).AddTicks(7582), new TimeSpan(0, 0, 0, 0, 0)));

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
                            ID = new Guid("751461f6-911c-473d-968e-33b8b1f96d2e"),
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(3469), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Flower 1",
                            Price = 500.0
                        },
                        new
                        {
                            ID = new Guid("07b4eac2-0ba8-475a-a518-93411bbedb64"),
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 30, 23, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(3472), new TimeSpan(0, 7, 0, 0, 0)),
                            Name = "Flower 2",
                            Price = 600.0
                        },
                        new
                        {
                            ID = new Guid("f2c0db79-96de-4a55-8c79-36b07c49bf83"),
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(3494), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Flower 3",
                            Price = 450.0
                        },
                        new
                        {
                            ID = new Guid("77e8bcb4-da8d-4253-9074-ef439405bd2c"),
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 30, 23, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(3506), new TimeSpan(0, 7, 0, 0, 0)),
                            Name = "Flower 4",
                            Price = 420.0
                        });
                });

            modelBuilder.Entity("ASP_28_12.Domains.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("ASP_28_12.Domains.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValue(new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(1977), new TimeSpan(0, 0, 0, 0, 0)));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("68b60ad0-5cca-4fb0-8690-39c23b319b94"),
                            AccessFailedCount = 0,
                            Address = "Tuyên Quang",
                            ConcurrencyStamp = "baa32c0e-54ab-490d-ade7-73118c49f41a",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 30, 23, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(3582), new TimeSpan(0, 7, 0, 0, 0)),
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "0349485127",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "User 1"
                        },
                        new
                        {
                            Id = new Guid("8f88d1e7-989e-4038-aca3-c126190a92f1"),
                            AccessFailedCount = 0,
                            Address = "Tuyên Quang",
                            ConcurrencyStamp = "34074ac6-c761-4930-8a2a-d2e5204b8d4c",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 30, 23, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(3586), new TimeSpan(0, 7, 0, 0, 0)),
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "0349485127",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "User 2"
                        },
                        new
                        {
                            Id = new Guid("5fb9ea39-e816-452b-a92b-98e33b1f916a"),
                            AccessFailedCount = 0,
                            Address = "Tuyên Quang",
                            ConcurrencyStamp = "2a054f47-2398-4089-9c4e-d07966e91dfc",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 30, 23, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(3588), new TimeSpan(0, 7, 0, 0, 0)),
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "0349485127",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "User 3"
                        },
                        new
                        {
                            Id = new Guid("e7cca615-b1e0-4d8b-95b1-279a1040e903"),
                            AccessFailedCount = 0,
                            Address = "Tuyên Quang",
                            ConcurrencyStamp = "a31b0bb6-0c0e-4d6f-8f4e-51f0c5902899",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 30, 23, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(3594), new TimeSpan(0, 7, 0, 0, 0)),
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "0349485127",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "User 4"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens", (string)null);
                });

            modelBuilder.Entity("ASP_28_12.Domains.Entities.Order", b =>
                {
                    b.HasOne("ASP_28_12.Domains.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP_28_12.Domains.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("User");
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

            modelBuilder.Entity("ASP_28_12.Domains.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
