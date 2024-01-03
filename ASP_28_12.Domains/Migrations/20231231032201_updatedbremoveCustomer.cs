using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_28_12.Domains.Migrations
{
    public partial class updatedbremoveCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders");

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
                name: "CustomerID",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Users",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(1598), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(5164), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Products",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 68, DateTimeKind.Unspecified).AddTicks(7557), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 68, DateTimeKind.Unspecified).AddTicks(8045), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(1066), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CreatedDate", "Name", "Price", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("095b5bba-61a9-4224-82c7-52b3c08f4b05"), new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(3416), new TimeSpan(0, 0, 0, 0, 0)), "Flower 3", 450.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("0e8b3f84-6a20-4b32-8d89-86d39ae39e86"), new DateTimeOffset(new DateTime(2023, 12, 31, 10, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(3396), new TimeSpan(0, 7, 0, 0, 0)), "Flower 2", 600.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("15948c02-8324-42ca-83f4-2fb076c40d59"), new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(3393), new TimeSpan(0, 0, 0, 0, 0)), "Flower 1", 500.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("a3701069-cc10-4105-b294-1f30cd9a3468"), new DateTimeOffset(new DateTime(2023, 12, 31, 10, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(3417), new TimeSpan(0, 7, 0, 0, 0)), "Flower 4", 420.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UrlImage", "UserName" },
                values: new object[,]
                {
                    { new Guid("848db435-a2a8-4045-bd44-1a0aa64b3764"), 0, "Tuyên Quang", "746659bd-f460-4629-8fad-e24309df51e9", new DateTimeOffset(new DateTime(2023, 12, 31, 10, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(3516), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 3" },
                    { new Guid("cefcf843-13c8-4e08-8c7c-982fc6f0bbb6"), 0, "Tuyên Quang", "04cc2f9e-f28b-4060-824f-9f463dfe1b02", new DateTimeOffset(new DateTime(2023, 12, 31, 10, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(3519), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 4" },
                    { new Guid("ee685205-ff00-498c-b237-a79e43d9d89a"), 0, "Tuyên Quang", "02e3e400-48a4-4723-9273-138216c004da", new DateTimeOffset(new DateTime(2023, 12, 31, 10, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(3511), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 2" },
                    { new Guid("f6e922b9-760f-47e2-8761-dea1ff4e774c"), 0, "Tuyên Quang", "1db33616-a4a3-4f7c-b0b3-fd6ee6ab9c7c", new DateTimeOffset(new DateTime(2023, 12, 31, 10, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(3507), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("095b5bba-61a9-4224-82c7-52b3c08f4b05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("0e8b3f84-6a20-4b32-8d89-86d39ae39e86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("15948c02-8324-42ca-83f4-2fb076c40d59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("a3701069-cc10-4105-b294-1f30cd9a3468"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("848db435-a2a8-4045-bd44-1a0aa64b3764"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cefcf843-13c8-4e08-8c7c-982fc6f0bbb6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee685205-ff00-498c-b237-a79e43d9d89a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6e922b9-760f-47e2-8761-dea1ff4e774c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Users",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(5164), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(1598), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Products",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 68, DateTimeKind.Unspecified).AddTicks(7557), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 30, 17, 31, 10, 412, DateTimeKind.Unspecified).AddTicks(1066), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 68, DateTimeKind.Unspecified).AddTicks(8045), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerID",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
