using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_28_12.Domains.Migrations
{
    public partial class updataIden : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("80379a2e-6754-4966-a6be-7054b82eb352"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("c7ce01fc-cbb5-4279-8b86-795fcadac4af"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("c898b268-6de5-4e98-96ff-359e1a8b4bf3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("f8a3ec44-1975-4513-ab6d-8d82cdf42566"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("4634ff15-3447-4fd2-8ccb-6e5d7f750433"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("4c5ff00a-2929-4f69-99cc-cf41f5cab736"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("5b835afb-0b66-4aea-9804-e511b1cdbf7f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("efb6a8c8-8ba7-4a68-a100-8ee84737ed96"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 29, 6, 9, 12, 608, DateTimeKind.Unspecified).AddTicks(9159), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 29, 2, 56, 59, 673, DateTimeKind.Unspecified).AddTicks(8532), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<Guid>(
                name: "UserID",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Address", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("09d033f8-ff4e-4528-a379-8cabfc7b6373"), "Hà Nội", "Customer 1", "0349485127 " },
                    { new Guid("176fa7c8-08c9-4eab-af8a-45de7ceac492"), "Hà Nội", "Customer 4", "0349485127 " },
                    { new Guid("1ce1f94b-368e-47fe-a31f-aa8a263007da"), "Hà Nội", "Customer 2", "0349485127 " },
                    { new Guid("211a1fc2-6ffb-4f8d-a51c-ffc820398fff"), "Hà Nội", "Customer 3", "0349485127 " }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("32c40087-5355-439e-9a2a-993aaedaf8ed"), "Flower 4", 420.0 },
                    { new Guid("62df8b90-5a34-486a-b8ba-5d6fde118253"), "Flower 2", 600.0 },
                    { new Guid("8b12cdce-c49d-4344-928b-53abac7f73b2"), "Flower 1", 500.0 },
                    { new Guid("d42cb679-fe6d-412c-b5ac-945741ad83f6"), "Flower 3", 450.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("25a9a642-a209-450a-88f4-bea2dcb2def4"), 0, "Tuyên Quang", "4b4e3366-5383-40b9-ab53-c1c6b958c50c", null, false, false, null, null, null, null, "0349485127", false, null, false, "User 1" },
                    { new Guid("3548962a-b22c-43a1-a265-fbfc3c0da742"), 0, "Tuyên Quang", "77ccd9bc-110e-40ac-a701-feb59d9d2720", null, false, false, null, null, null, null, "0349485127", false, null, false, "User 2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserID",
                table: "Orders",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserID",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserID",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("09d033f8-ff4e-4528-a379-8cabfc7b6373"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("176fa7c8-08c9-4eab-af8a-45de7ceac492"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("1ce1f94b-368e-47fe-a31f-aa8a263007da"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("211a1fc2-6ffb-4f8d-a51c-ffc820398fff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("32c40087-5355-439e-9a2a-993aaedaf8ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("62df8b90-5a34-486a-b8ba-5d6fde118253"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("8b12cdce-c49d-4344-928b-53abac7f73b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("d42cb679-fe6d-412c-b5ac-945741ad83f6"));

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 29, 2, 56, 59, 673, DateTimeKind.Unspecified).AddTicks(8532), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 29, 6, 9, 12, 608, DateTimeKind.Unspecified).AddTicks(9159), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Address", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("80379a2e-6754-4966-a6be-7054b82eb352"), "Hà Nội", "Customer 1", "0349485127 " },
                    { new Guid("c7ce01fc-cbb5-4279-8b86-795fcadac4af"), "Hà Nội", "Customer 4", "0349485127 " },
                    { new Guid("c898b268-6de5-4e98-96ff-359e1a8b4bf3"), "Hà Nội", "Customer 2", "0349485127 " },
                    { new Guid("f8a3ec44-1975-4513-ab6d-8d82cdf42566"), "Hà Nội", "Customer 3", "0349485127 " }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("4634ff15-3447-4fd2-8ccb-6e5d7f750433"), "Flower 2", 600.0 },
                    { new Guid("4c5ff00a-2929-4f69-99cc-cf41f5cab736"), "Flower 3", 450.0 },
                    { new Guid("5b835afb-0b66-4aea-9804-e511b1cdbf7f"), "Flower 1", 500.0 },
                    { new Guid("efb6a8c8-8ba7-4a68-a100-8ee84737ed96"), "Flower 4", 420.0 }
                });
        }
    }
}
