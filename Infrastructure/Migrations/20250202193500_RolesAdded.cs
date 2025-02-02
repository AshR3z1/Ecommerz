using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RolesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dbb7898-5174-4b9d-9237-70b235fc3ab3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13138fb5-0493-4761-a042-03e135485d52");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4ac7e3c3-f3e2-4ae7-a2f3-7ebafb8c4a69", null, "Customer", "CUSTOMER" },
                    { "5a92ff1c-3821-4a9d-ad56-ae13d15c5f6b", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ac7e3c3-f3e2-4ae7-a2f3-7ebafb8c4a69");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a92ff1c-3821-4a9d-ad56-ae13d15c5f6b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0dbb7898-5174-4b9d-9237-70b235fc3ab3", null, "Customer", "CUSTOMER" },
                    { "13138fb5-0493-4761-a042-03e135485d52", null, "Admin", "ADMIN" }
                });
        }
    }
}
