using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INTERNET_SHOP.Migrations
{
    /// <inheritdoc />
    public partial class AddedExternalIptoUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExternalIp",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExternalIp",
                table: "User");
        }
    }
}
