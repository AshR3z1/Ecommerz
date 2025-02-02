using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CouponsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8a3e7bb-b00f-4ceb-8e59-8f034c4b8797");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0e86c9e-210c-4fc5-bbe1-5d040954f7ee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0dbb7898-5174-4b9d-9237-70b235fc3ab3", null, "Customer", "CUSTOMER" },
                    { "13138fb5-0493-4761-a042-03e135485d52", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "d8a3e7bb-b00f-4ceb-8e59-8f034c4b8797", null, "Admin", "ADMIN" },
                    { "e0e86c9e-210c-4fc5-bbe1-5d040954f7ee", null, "Customer", "CUSTOMER" }
                });
        }
    }
}
