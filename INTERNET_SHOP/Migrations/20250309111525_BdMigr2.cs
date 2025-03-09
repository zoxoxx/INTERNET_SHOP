using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INTERNET_SHOP.Migrations
{
    /// <inheritdoc />
    public partial class BdMigr2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserAutorizeId",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAutorize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAutorize", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAutorize_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_UserAutorizeId",
                table: "Ticket",
                column: "UserAutorizeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAutorize_RoleId",
                table: "UserAutorize",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_UserAutorize_UserAutorizeId",
                table: "Ticket",
                column: "UserAutorizeId",
                principalTable: "UserAutorize",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_UserAutorize_UserAutorizeId",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "UserAutorize");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_UserAutorizeId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "UserAutorizeId",
                table: "Ticket");
        }
    }
}
