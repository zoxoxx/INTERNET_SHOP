using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INTERNET_SHOP.Migrations
{
    /// <inheritdoc />
    public partial class DbMigrNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Product",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PriceCoefficient",
                table: "Position",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "PriceCoefficient",
                table: "Position");
        }
    }
}
