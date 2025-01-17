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
    [Migration("20231231032201_updatedbremoveCustomer")]
    partial class updatedbremoveCustomer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASP_28_12.Domains.Entities.Order", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("OrderDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValue(new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 68, DateTimeKind.Unspecified).AddTicks(8045), new TimeSpan(0, 0, 0, 0, 0)));

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TotalFee")
                        .HasColumnType("int");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

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
                        .HasDefaultValue(new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 68, DateTimeKind.Unspecified).AddTicks(7557), new TimeSpan(0, 0, 0, 0, 0)));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("UrlImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            ID = new Guid("15948c02-8324-42ca-83f4-2fb076c40d59"),
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(3393), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Flower 1",
                            Price = 500.0,
                            UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg"
                        },
                        new
                        {
                            ID = new Guid("0e8b3f84-6a20-4b32-8d89-86d39ae39e86"),
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 31, 10, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(3396), new TimeSpan(0, 7, 0, 0, 0)),
                            Name = "Flower 2",
                            Price = 600.0,
                            UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg"
                        },
                        new
                        {
                            ID = new Guid("095b5bba-61a9-4224-82c7-52b3c08f4b05"),
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(3416), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Flower 3",
                            Price = 450.0,
                            UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg"
                        },
                        new
                        {
                            ID = new Guid("a3701069-cc10-4105-b294-1f30cd9a3468"),
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 31, 10, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(3417), new TimeSpan(0, 7, 0, 0, 0)),
                            Name = "Flower 4",
                            Price = 420.0,
                            UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg"
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
                        .HasDefaultValue(new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(1598), new TimeSpan(0, 0, 0, 0, 0)));

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

                    b.Property<string>("UrlImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("f6e922b9-760f-47e2-8761-dea1ff4e774c"),
                            AccessFailedCount = 0,
                            Address = "Tuyên Quang",
                            ConcurrencyStamp = "1db33616-a4a3-4f7c-b0b3-fd6ee6ab9c7c",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 31, 10, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(3507), new TimeSpan(0, 7, 0, 0, 0)),
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "0349485127",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg",
                            UserName = "User 1"
                        },
                        new
                        {
                            Id = new Guid("ee685205-ff00-498c-b237-a79e43d9d89a"),
                            AccessFailedCount = 0,
                            Address = "Tuyên Quang",
                            ConcurrencyStamp = "02e3e400-48a4-4723-9273-138216c004da",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 31, 10, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(3511), new TimeSpan(0, 7, 0, 0, 0)),
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "0349485127",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg",
                            UserName = "User 2"
                        },
                        new
                        {
                            Id = new Guid("848db435-a2a8-4045-bd44-1a0aa64b3764"),
                            AccessFailedCount = 0,
                            Address = "Tuyên Quang",
                            ConcurrencyStamp = "746659bd-f460-4629-8fad-e24309df51e9",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 31, 10, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(3516), new TimeSpan(0, 7, 0, 0, 0)),
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "0349485127",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg",
                            UserName = "User 3"
                        },
                        new
                        {
                            Id = new Guid("cefcf843-13c8-4e08-8c7c-982fc6f0bbb6"),
                            AccessFailedCount = 0,
                            Address = "Tuyên Quang",
                            ConcurrencyStamp = "04cc2f9e-f28b-4060-824f-9f463dfe1b02",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 31, 10, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(3519), new TimeSpan(0, 7, 0, 0, 0)),
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "0349485127",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg",
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
                    b.HasOne("ASP_28_12.Domains.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
