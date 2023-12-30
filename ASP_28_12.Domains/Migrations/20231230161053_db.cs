using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_28_12.Domains.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25a9a642-a209-450a-88f4-bea2dcb2def4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3548962a-b22c-43a1-a265-fbfc3c0da742"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Users",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 457, DateTimeKind.Unspecified).AddTicks(1977), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Products",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 456, DateTimeKind.Unspecified).AddTicks(7582), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 456, DateTimeKind.Unspecified).AddTicks(8028), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 29, 6, 9, 12, 608, DateTimeKind.Unspecified).AddTicks(9159), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "TotalFee",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TotalFee",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 29, 6, 9, 12, 608, DateTimeKind.Unspecified).AddTicks(9159), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 16, 10, 53, 456, DateTimeKind.Unspecified).AddTicks(8028), new TimeSpan(0, 0, 0, 0, 0)));

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
        }
    }
}
