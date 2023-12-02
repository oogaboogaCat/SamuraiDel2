using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class JegElskerNina : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Samurai",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SamuraiHair",
                table: "Samurai",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Sitat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ESitatStil = table.Column<int>(type: "int", nullable: true),
                    SamuraiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sitat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sitat_Samurai_SamuraiId",
                        column: x => x.SamuraiId,
                        principalTable: "Samurai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sitat_SamuraiId",
                table: "Sitat",
                column: "SamuraiId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sitat");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Samurai");

            migrationBuilder.DropColumn(
                name: "SamuraiHair",
                table: "Samurai");
        }
    }
}
