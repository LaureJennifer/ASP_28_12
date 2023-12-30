using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_28_12.Domains.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 29, 2, 56, 59, 673, DateTimeKind.Unspecified).AddTicks(8532), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 28, 15, 11, 40, 775, DateTimeKind.Unspecified).AddTicks(7071), new TimeSpan(0, 0, 0, 0, 0)));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTimeOffset(new DateTime(2023, 12, 28, 15, 11, 40, 775, DateTimeKind.Unspecified).AddTicks(7071), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2023, 12, 29, 2, 56, 59, 673, DateTimeKind.Unspecified).AddTicks(8532), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
