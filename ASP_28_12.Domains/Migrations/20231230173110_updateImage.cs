using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_28_12.Domains.Migrations
{
    public partial class updateImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("07b4eac2-0ba8-475a-a518-93411bbedb64"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("751461f6-911c-473d-968e-33b8b1f96d2e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("77e8bcb4-da8d-4253-9074-ef439405bd2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("f2c0db79-96de-4a55-8c79-36b07c49bf83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb9ea39-e816-452b-a92b-98e33b1f916a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68b60ad0-5cca-4fb0-8690-39c23b319b94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f88d1e7-989e-4038-aca3-c126190a92f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7cca615-b1e0-4d8b-95b1-279a1040e903"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Users",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(5164), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(1977), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Products",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 456, DateTimeKind.Unspecified).AddTicks(7582), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(1066), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 456, DateTimeKind.Unspecified).AddTicks(8028), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CreatedDate", "Name", "Price", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("2b779b44-d7b8-4c9c-a025-1499fa49dded"), new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(6982), new TimeSpan(0, 0, 0, 0, 0)), "Flower 3", 450.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("3237bcdd-b231-4225-b403-e7f33915bfb3"), new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(6956), new TimeSpan(0, 0, 0, 0, 0)), "Flower 1", 500.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("430a5898-1afc-48ed-aa0e-6ea94b109dfc"), new DateTimeOffset(new DateTime(2023, 12, 31, 0, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(6958), new TimeSpan(0, 7, 0, 0, 0)), "Flower 2", 600.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("70d0570d-88e1-4cf9-8c1d-1a49d1c82a49"), new DateTimeOffset(new DateTime(2023, 12, 31, 0, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(6983), new TimeSpan(0, 7, 0, 0, 0)), "Flower 4", 420.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UrlImage", "UserName" },
                values: new object[,]
                {
                    { new Guid("532a2bc2-54f2-4685-bf2c-cc888943a494"), 0, "Tuyên Quang", "2e8dd129-cf3f-4376-85dc-b8e9f4ddb26f", new DateTimeOffset(new DateTime(2023, 12, 31, 0, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(7093), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 1" },
                    { new Guid("542cde60-909a-4092-925a-8066352c15db"), 0, "Tuyên Quang", "cf74db21-1784-4f35-a408-349c0a049d3f", new DateTimeOffset(new DateTime(2023, 12, 31, 0, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(7118), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 4" },
                    { new Guid("94ec1cc3-c1ff-4812-a643-064bd0d78329"), 0, "Tuyên Quang", "d92f9465-41db-4e68-8780-2f8b831951fb", new DateTimeOffset(new DateTime(2023, 12, 31, 0, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(7115), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 3" },
                    { new Guid("bd24e340-8e73-46ff-a38d-ba4f7e0e07da"), 0, "Tuyên Quang", "8914fc43-7e5e-48d0-bab5-343a704e80f7", new DateTimeOffset(new DateTime(2023, 12, 31, 0, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(7111), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("2b779b44-d7b8-4c9c-a025-1499fa49dded"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("3237bcdd-b231-4225-b403-e7f33915bfb3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("430a5898-1afc-48ed-aa0e-6ea94b109dfc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("70d0570d-88e1-4cf9-8c1d-1a49d1c82a49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("532a2bc2-54f2-4685-bf2c-cc888943a494"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("542cde60-909a-4092-925a-8066352c15db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94ec1cc3-c1ff-4812-a643-064bd0d78329"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd24e340-8e73-46ff-a38d-ba4f7e0e07da"));

            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Products");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Users",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(1977), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(5164), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Products",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 456, DateTimeKind.Unspecified).AddTicks(7582), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 456, DateTimeKind.Unspecified).AddTicks(8028), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(1066), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CreatedDate", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("07b4eac2-0ba8-475a-a518-93411bbedb64"), new DateTimeOffset(new DateTime(2023, 12, 30, 23, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(3472), new TimeSpan(0, 7, 0, 0, 0)), "Flower 2", 600.0 },
                    { new Guid("751461f6-911c-473d-968e-33b8b1f96d2e"), new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(3469), new TimeSpan(0, 0, 0, 0, 0)), "Flower 1", 500.0 },
                    { new Guid("77e8bcb4-da8d-4253-9074-ef439405bd2c"), new DateTimeOffset(new DateTime(2023, 12, 30, 23, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(3506), new TimeSpan(0, 7, 0, 0, 0)), "Flower 4", 420.0 },
                    { new Guid("f2c0db79-96de-4a55-8c79-36b07c49bf83"), new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(3494), new TimeSpan(0, 0, 0, 0, 0)), "Flower 3", 450.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("5fb9ea39-e816-452b-a92b-98e33b1f916a"), 0, "Tuyên Quang", "2a054f47-2398-4089-9c4e-d07966e91dfc", new DateTimeOffset(new DateTime(2023, 12, 30, 23, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(3588), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "User 3" },
                    { new Guid("68b60ad0-5cca-4fb0-8690-39c23b319b94"), 0, "Tuyên Quang", "baa32c0e-54ab-490d-ade7-73118c49f41a", new DateTimeOffset(new DateTime(2023, 12, 30, 23, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(3582), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "User 1" },
                    { new Guid("8f88d1e7-989e-4038-aca3-c126190a92f1"), 0, "Tuyên Quang", "34074ac6-c761-4930-8a2a-d2e5204b8d4c", new DateTimeOffset(new DateTime(2023, 12, 30, 23, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(3586), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "User 2" },
                    { new Guid("e7cca615-b1e0-4d8b-95b1-279a1040e903"), 0, "Tuyên Quang", "a31b0bb6-0c0e-4d6f-8f4e-51f0c5902899", new DateTimeOffset(new DateTime(2023, 12, 30, 23, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(3594), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "User 4" }
                });
        }
    }
}
