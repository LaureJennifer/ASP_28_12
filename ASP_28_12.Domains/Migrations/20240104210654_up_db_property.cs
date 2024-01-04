using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_28_12.Domains.Migrations
{
    public partial class up_db_property : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 21, 6, 54, 320, DateTimeKind.Unspecified).AddTicks(8368), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 17, 43, 26, 530, DateTimeKind.Unspecified).AddTicks(2574), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Products",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 21, 6, 54, 320, DateTimeKind.Unspecified).AddTicks(5276), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 17, 43, 26, 529, DateTimeKind.Unspecified).AddTicks(9395), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 21, 6, 54, 320, DateTimeKind.Unspecified).AddTicks(5765), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 17, 43, 26, 529, DateTimeKind.Unspecified).AddTicks(9889), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CreatedDate", "Name", "Price", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("3e12265c-b0e4-4b43-be18-01af57580ce2"), new DateTimeOffset(new DateTime(2024, 1, 4, 21, 6, 54, 321, DateTimeKind.Unspecified).AddTicks(47), new TimeSpan(0, 0, 0, 0, 0)), "Flower 1", 500.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("46a5e7c9-14da-4fe8-91af-3fa1041fcc1f"), new DateTimeOffset(new DateTime(2024, 1, 4, 21, 6, 54, 321, DateTimeKind.Unspecified).AddTicks(66), new TimeSpan(0, 0, 0, 0, 0)), "Flower 3", 450.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("67d3e2c7-2efe-4996-a5f1-3e92999e52ad"), new DateTimeOffset(new DateTime(2024, 1, 5, 4, 6, 54, 321, DateTimeKind.Unspecified).AddTicks(49), new TimeSpan(0, 7, 0, 0, 0)), "Flower 2", 600.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" },
                    { new Guid("7d305a2f-dca5-462a-862d-e350567c92e9"), new DateTimeOffset(new DateTime(2024, 1, 5, 4, 6, 54, 321, DateTimeKind.Unspecified).AddTicks(67), new TimeSpan(0, 7, 0, 0, 0)), "Flower 4", 420.0, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UrlImage", "UserName" },
                values: new object[,]
                {
                    { new Guid("0754d68b-a377-44e3-92bb-5d9ea036d0e7"), 0, "Tuyên Quang", "7e7a23cd-f173-417a-800c-ebdb33212cde", new DateTimeOffset(new DateTime(2024, 1, 5, 4, 6, 54, 321, DateTimeKind.Unspecified).AddTicks(174), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 2" },
                    { new Guid("17cd928c-475f-4915-9935-791657ecf3d7"), 0, "Tuyên Quang", "4e16ec99-8447-4055-ac85-116779746792", new DateTimeOffset(new DateTime(2024, 1, 5, 4, 6, 54, 321, DateTimeKind.Unspecified).AddTicks(180), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 4" },
                    { new Guid("70b97e43-837d-4f24-934f-cc29d1a289a9"), 0, "Tuyên Quang", "18a178d5-1e94-4612-833c-2eb0d6150601", new DateTimeOffset(new DateTime(2024, 1, 5, 4, 6, 54, 321, DateTimeKind.Unspecified).AddTicks(178), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 3" },
                    { new Guid("e9e13f08-c4a4-4a65-90cf-c0ed627c22e5"), 0, "Tuyên Quang", "7c518657-117d-4656-8ad1-e05fb8091857", new DateTimeOffset(new DateTime(2024, 1, 5, 4, 6, 54, 321, DateTimeKind.Unspecified).AddTicks(157), new TimeSpan(0, 7, 0, 0, 0)), null, false, false, null, null, null, null, "0349485127", false, null, false, "https://i.pinimg.com/564x/af/8c/a5/af8ca581043ca4c3a25252344a5a7b34.jpg", "User 1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("3e12265c-b0e4-4b43-be18-01af57580ce2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("46a5e7c9-14da-4fe8-91af-3fa1041fcc1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("67d3e2c7-2efe-4996-a5f1-3e92999e52ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("7d305a2f-dca5-462a-862d-e350567c92e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0754d68b-a377-44e3-92bb-5d9ea036d0e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17cd928c-475f-4915-9935-791657ecf3d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70b97e43-837d-4f24-934f-cc29d1a289a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9e13f08-c4a4-4a65-90cf-c0ed627c22e5"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Users",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 17, 43, 26, 530, DateTimeKind.Unspecified).AddTicks(2574), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 21, 6, 54, 320, DateTimeKind.Unspecified).AddTicks(8368), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Products",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 17, 43, 26, 529, DateTimeKind.Unspecified).AddTicks(9395), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 21, 6, 54, 320, DateTimeKind.Unspecified).AddTicks(5276), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 17, 43, 26, 529, DateTimeKind.Unspecified).AddTicks(9889), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 4, 21, 6, 54, 320, DateTimeKind.Unspecified).AddTicks(5765), new TimeSpan(0, 0, 0, 0, 0)));

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
    }
}
