using Microsoft.EntityFrameworkCore.Migrations;

namespace RobotArena.Data.Migrations
{
    public partial class robot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Robots",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RankPlace",
                table: "Robots",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Robots");

            migrationBuilder.DropColumn(
                name: "RankPlace",
                table: "Robots");
        }
    }
}
