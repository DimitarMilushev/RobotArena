using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RobotArena.Data.Migrations
{
    public partial class arena : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArenaId",
                table: "Creeps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Arenas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arenas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Creeps_ArenaId",
                table: "Creeps",
                column: "ArenaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Creeps_Arenas_ArenaId",
                table: "Creeps",
                column: "ArenaId",
                principalTable: "Arenas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Creeps_Arenas_ArenaId",
                table: "Creeps");

            migrationBuilder.DropTable(
                name: "Arenas");

            migrationBuilder.DropIndex(
                name: "IX_Creeps_ArenaId",
                table: "Creeps");

            migrationBuilder.DropColumn(
                name: "ArenaId",
                table: "Creeps");
        }
    }
}
