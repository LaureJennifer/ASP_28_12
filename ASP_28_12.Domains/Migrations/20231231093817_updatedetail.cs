using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_28_12.Domains.Migrations
{
    public partial class updatedetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("6471b1c0-5e6a-4045-9da3-13367a02508c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("9051850a-18b3-476f-a43a-6aefb49e53df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("d5a9fe7e-b0b0-4162-a1ef-9a92669c4a34"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("ec3fbee9-36c9-4fbc-8098-a2fb6f18386f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ea05476-18bc-4591-be64-5520c2d3549c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("556e080a-6204-4934-b7dc-f6ee2e931890"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bef7620-9820-4957-b9cf-1adb1e67d37a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d021da14-e0d3-4878-b73a-d11feacf27dd"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Users",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 9, 38, 17, 710, DateTimeKind.Unspecified).AddTicks(8852), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(7506), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Products",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 9, 38, 17, 710, DateTimeKind.Unspecified).AddTicks(5795), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(3621), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 9, 38, 17, 710, DateTimeKind.Unspecified).AddTicks(6244), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(4094), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<Guid>(
                name: "OrderDetailsID",
                table: "OrderDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "OrderDetailsID");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CreatedDate", "Name", "Price", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("054b3b56-3e51-4edb-a53c-794ce50a0b39"), new DateTimeOffset(new DateTime(2023, 12, 31, 9, 38, 17, 711, DateTimeKind.Unspecified).AddTicks(475), new TimeSpan(0, 0, 0, 0, 0)), "Flower 1", 500.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("34cdc981-d10a-4722-b362-6e3d7086044e"), new DateTimeOffset(new DateTime(2023, 12, 31, 9, 38, 17, 711, DateTimeKind.Unspecified).AddTicks(497), new TimeSpan(0, 0, 0, 0, 0)), "Flower 3", 450.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("66c5ac8a-b972-438e-9a3f-77d79e1189cb"), new DateTimeOffset(new DateTime(2023, 12, 31, 16, 38, 17, 711, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 7, 0, 0, 0)), "Flower 4", 420.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("dda0e84b-a85a-4aa6-b8a4-aa62746c7090"), new DateTimeOffset(new DateTime(2023, 12, 31, 16, 38, 17, 711, DateTimeKind.Unspecified).AddTicks(477), new TimeSpan(0, 7, 0, 0, 0)), "Flower 2", 600.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UrlImage", "UserName" },
                values: new object[,]
                {
                    { new Guid("35fe33f6-075c-45ea-b09b-f36ed667f0e2"), 0, "Tuyên Quang", "527c4fac-1743-4e0f-a6a3-bf4e92a27c5d", new DateTimeOffset(new DateTime(2023, 12, 31, 16, 38, 17, 711, DateTimeKind.Unspecified).AddTicks(585), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 4" },
                    { new Guid("5d43dfa9-98ac-4c20-9f63-49ab1e097879"), 0, "Tuyên Quang", "9f21dcb1-cc40-4e76-8e05-4c1b4cae1cb3", new DateTimeOffset(new DateTime(2023, 12, 31, 16, 38, 17, 711, DateTimeKind.Unspecified).AddTicks(564), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 1" },
                    { new Guid("d0dc0223-e9c4-439d-bafe-8d627b869ba7"), 0, "Tuyên Quang", "eec65075-8622-469b-9554-1b761f29df71", new DateTimeOffset(new DateTime(2023, 12, 31, 16, 38, 17, 711, DateTimeKind.Unspecified).AddTicks(582), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 3" },
                    { new Guid("eea65711-cc36-45c5-b57b-7e15d0b5c1b2"), 0, "Tuyên Quang", "182d6af1-8d50-4312-a69e-6ae01f3e7acb", new DateTimeOffset(new DateTime(2023, 12, 31, 16, 38, 17, 711, DateTimeKind.Unspecified).AddTicks(579), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("054b3b56-3e51-4edb-a53c-794ce50a0b39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("34cdc981-d10a-4722-b362-6e3d7086044e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("66c5ac8a-b972-438e-9a3f-77d79e1189cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("dda0e84b-a85a-4aa6-b8a4-aa62746c7090"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35fe33f6-075c-45ea-b09b-f36ed667f0e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d43dfa9-98ac-4c20-9f63-49ab1e097879"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0dc0223-e9c4-439d-bafe-8d627b869ba7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eea65711-cc36-45c5-b57b-7e15d0b5c1b2"));

            migrationBuilder.DropColumn(
                name: "OrderDetailsID",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Users",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(7506), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 9, 38, 17, 710, DateTimeKind.Unspecified).AddTicks(8852), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Products",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(3621), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 9, 38, 17, 710, DateTimeKind.Unspecified).AddTicks(5795), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(4094), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 9, 38, 17, 710, DateTimeKind.Unspecified).AddTicks(6244), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                columns: new[] { "OrderID", "ProductID" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CreatedDate", "Name", "Price", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("6471b1c0-5e6a-4045-9da3-13367a02508c"), new DateTimeOffset(new DateTime(2023, 12, 31, 3, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(9149), new TimeSpan(0, 0, 0, 0, 0)), "Flower 1", 500.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("9051850a-18b3-476f-a43a-6aefb49e53df"), new DateTimeOffset(new DateTime(2023, 12, 31, 10, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(9151), new TimeSpan(0, 7, 0, 0, 0)), "Flower 2", 600.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("d5a9fe7e-b0b0-4162-a1ef-9a92669c4a34"), new DateTimeOffset(new DateTime(2023, 12, 31, 3, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(9173), new TimeSpan(0, 0, 0, 0, 0)), "Flower 3", 450.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("ec3fbee9-36c9-4fbc-8098-a2fb6f18386f"), new DateTimeOffset(new DateTime(2023, 12, 31, 10, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(9174), new TimeSpan(0, 7, 0, 0, 0)), "Flower 4", 420.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UrlImage", "UserName" },
                values: new object[,]
                {
                    { new Guid("1ea05476-18bc-4591-be64-5520c2d3549c"), 0, "Tuyên Quang", "16a3023e-828c-40e6-99ac-6d8725fde2ad", new DateTimeOffset(new DateTime(2023, 12, 31, 10, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(9282), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 3" },
                    { new Guid("556e080a-6204-4934-b7dc-f6ee2e931890"), 0, "Tuyên Quang", "123ecd17-861b-44ff-a9eb-f3449e4dcc16", new DateTimeOffset(new DateTime(2023, 12, 31, 10, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(9275), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 1" },
                    { new Guid("5bef7620-9820-4957-b9cf-1adb1e67d37a"), 0, "Tuyên Quang", "86e11bec-6866-42a4-bd96-68f581cee3c7", new DateTimeOffset(new DateTime(2023, 12, 31, 10, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(9285), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 4" },
                    { new Guid("d021da14-e0d3-4878-b73a-d11feacf27dd"), 0, "Tuyên Quang", "00c745c4-fd1b-4010-ba3f-6170fa25bd68", new DateTimeOffset(new DateTime(2023, 12, 31, 10, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(9279), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 2" }
                });
        }
    }
}
