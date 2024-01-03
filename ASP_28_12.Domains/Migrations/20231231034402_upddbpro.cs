using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_28_12.Domains.Migrations
{
    public partial class upddbpro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(7506), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(1598), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Products",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(3621), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 68, DateTimeKind.Unspecified).AddTicks(7557), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(4094), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 68, DateTimeKind.Unspecified).AddTicks(8045), new TimeSpan(0, 0, 0, 0, 0)));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 69, DateTimeKind.Unspecified).AddTicks(1598), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(7506), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Products",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 68, DateTimeKind.Unspecified).AddTicks(7557), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(3621), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 22, 1, 68, DateTimeKind.Unspecified).AddTicks(8045), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 31, 3, 44, 2, 451, DateTimeKind.Unspecified).AddTicks(4094), new TimeSpan(0, 0, 0, 0, 0)));

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
    }
}
