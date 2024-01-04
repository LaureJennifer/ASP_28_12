using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_28_12.Domains.Migrations
{
    public partial class db51 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Users",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 17, 43, 26, 530, DateTimeKind.Unspecified).AddTicks(2574), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 9, 38, 17, 710, DateTimeKind.Unspecified).AddTicks(8852), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Products",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 17, 43, 26, 529, DateTimeKind.Unspecified).AddTicks(9395), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 9, 38, 17, 710, DateTimeKind.Unspecified).AddTicks(5795), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 17, 43, 26, 529, DateTimeKind.Unspecified).AddTicks(9889), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 9, 38, 17, 710, DateTimeKind.Unspecified).AddTicks(6244), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CreatedDate", "Name", "Price", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("23c9ecc7-c310-427c-b253-55bd27498d76"), new DateTimeOffset(new DateTime(2024, 1, 4, 17, 43, 26, 530, DateTimeKind.Unspecified).AddTicks(4470), new TimeSpan(0, 0, 0, 0, 0)), "Flower 3", 450.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("2a8edda8-1613-408a-aa15-1fa4c044a5ae"), new DateTimeOffset(new DateTime(2024, 1, 4, 17, 43, 26, 530, DateTimeKind.Unspecified).AddTicks(4433), new TimeSpan(0, 0, 0, 0, 0)), "Flower 1", 500.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("9be43810-af7c-4839-8013-7ebbd8b246d7"), new DateTimeOffset(new DateTime(2024, 1, 5, 0, 43, 26, 530, DateTimeKind.Unspecified).AddTicks(4448), new TimeSpan(0, 7, 0, 0, 0)), "Flower 2", 600.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("a090e9fb-bf8c-4fcb-940a-273faa6331ec"), new DateTimeOffset(new DateTime(2024, 1, 5, 0, 43, 26, 530, DateTimeKind.Unspecified).AddTicks(4471), new TimeSpan(0, 7, 0, 0, 0)), "Flower 4", 420.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UrlImage", "UserName" },
                values: new object[,]
                {
                    { new Guid("0c62d6f3-cd6e-4dc3-a7f2-adb5cefcb812"), 0, "Tuyên Quang", "aa66b1bd-4b63-4221-877c-96c897086f67", new DateTimeOffset(new DateTime(2024, 1, 5, 0, 43, 26, 530, DateTimeKind.Unspecified).AddTicks(4540), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 2" },
                    { new Guid("33c2eae2-b327-4c26-afa0-5d9a598cec54"), 0, "Tuyên Quang", "445e4596-aa84-4f45-a5ef-ba29cfc6d150", new DateTimeOffset(new DateTime(2024, 1, 5, 0, 43, 26, 530, DateTimeKind.Unspecified).AddTicks(4549), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 4" },
                    { new Guid("414e33d1-c6c3-4830-bb0c-f8fa691f14f8"), 0, "Tuyên Quang", "8f3d9fbb-f6d7-4b55-a438-24b5058d6c78", new DateTimeOffset(new DateTime(2024, 1, 5, 0, 43, 26, 530, DateTimeKind.Unspecified).AddTicks(4546), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 3" },
                    { new Guid("fbd34e82-b798-408b-9681-82bde2dc6004"), 0, "Tuyên Quang", "bd84e407-b403-4b39-9a39-96226df5b014", new DateTimeOffset(new DateTime(2024, 1, 5, 0, 43, 26, 530, DateTimeKind.Unspecified).AddTicks(4536), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("23c9ecc7-c310-427c-b253-55bd27498d76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("2a8edda8-1613-408a-aa15-1fa4c044a5ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("9be43810-af7c-4839-8013-7ebbd8b246d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("a090e9fb-bf8c-4fcb-940a-273faa6331ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c62d6f3-cd6e-4dc3-a7f2-adb5cefcb812"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33c2eae2-b327-4c26-afa0-5d9a598cec54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("414e33d1-c6c3-4830-bb0c-f8fa691f14f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbd34e82-b798-408b-9681-82bde2dc6004"));

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Users",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 9, 38, 17, 710, DateTimeKind.Unspecified).AddTicks(8852), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 17, 43, 26, 530, DateTimeKind.Unspecified).AddTicks(2574), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Products",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 9, 38, 17, 710, DateTimeKind.Unspecified).AddTicks(5795), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 17, 43, 26, 529, DateTimeKind.Unspecified).AddTicks(9395), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 9, 38, 17, 710, DateTimeKind.Unspecified).AddTicks(6244), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 17, 43, 26, 529, DateTimeKind.Unspecified).AddTicks(9889), new TimeSpan(0, 0, 0, 0, 0)));

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
        }
    }
}
