﻿// <auto-generated />
using System;
using ASP_28_12.Domains.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP_28_12.Domains.Migrations
{
    [DbContext(typeof(FlowerDbContext))]
    partial class FlowerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasDefaultValue(new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(1066), new TimeSpan(0, 0, 0, 0, 0)));

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
                        .HasDefaultValue(new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 0, 0, 0, 0)));

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
                            ID = new Guid("3237bcdd-b231-4225-b403-e7f33915bfb3"),
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(6956), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Flower 1",
                            Price = 500.0,
                            UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg"
                        },
                        new
                        {
                            ID = new Guid("430a5898-1afc-48ed-aa0e-6ea94b109dfc"),
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 31, 0, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(6958), new TimeSpan(0, 7, 0, 0, 0)),
                            Name = "Flower 2",
                            Price = 600.0,
                            UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg"
                        },
                        new
                        {
                            ID = new Guid("2b779b44-d7b8-4c9c-a025-1499fa49dded"),
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(6982), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Flower 3",
                            Price = 450.0,
                            UrlImage = "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg"
                        },
                        new
                        {
                            ID = new Guid("70d0570d-88e1-4cf9-8c1d-1a49d1c82a49"),
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 31, 0, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(6983), new TimeSpan(0, 7, 0, 0, 0)),
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
                        .HasDefaultValue(new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(5164), new TimeSpan(0, 0, 0, 0, 0)));

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
                            Id = new Guid("532a2bc2-54f2-4685-bf2c-cc888943a494"),
                            AccessFailedCount = 0,
                            Address = "Tuyên Quang",
                            ConcurrencyStamp = "2e8dd129-cf3f-4376-85dc-b8e9f4ddb26f",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 31, 0, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(7093), new TimeSpan(0, 7, 0, 0, 0)),
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
                            Id = new Guid("bd24e340-8e73-46ff-a38d-ba4f7e0e07da"),
                            AccessFailedCount = 0,
                            Address = "Tuyên Quang",
                            ConcurrencyStamp = "8914fc43-7e5e-48d0-bab5-343a704e80f7",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 31, 0, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(7111), new TimeSpan(0, 7, 0, 0, 0)),
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
                            Id = new Guid("94ec1cc3-c1ff-4812-a643-064bd0d78329"),
                            AccessFailedCount = 0,
                            Address = "Tuyên Quang",
                            ConcurrencyStamp = "d92f9465-41db-4e68-8780-2f8b831951fb",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 31, 0, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(7115), new TimeSpan(0, 7, 0, 0, 0)),
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
                            Id = new Guid("542cde60-909a-4092-925a-8066352c15db"),
                            AccessFailedCount = 0,
                            Address = "Tuyên Quang",
                            ConcurrencyStamp = "cf74db21-1784-4f35-a408-349c0a049d3f",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 12, 31, 0, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(7118), new TimeSpan(0, 7, 0, 0, 0)),
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
