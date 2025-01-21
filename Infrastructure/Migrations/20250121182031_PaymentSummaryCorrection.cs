using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PaymentSummaryCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaymentSummary_Year",
                table: "Orders",
                newName: "PaymentSummary_ExpYear");

            migrationBuilder.RenameColumn(
                name: "ItemOrdered_Productname",
                table: "OrderItems",
                newName: "ItemOrdered_ProductName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaymentSummary_ExpYear",
                table: "Orders",
                newName: "PaymentSummary_Year");

            migrationBuilder.RenameColumn(
                name: "ItemOrdered_ProductName",
                table: "OrderItems",
                newName: "ItemOrdered_Productname");
        }
    }
}
