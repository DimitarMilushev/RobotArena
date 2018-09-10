using Microsoft.EntityFrameworkCore.Migrations;

namespace RobotArena.Data.Migrations
{
    public partial class stuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentHealth",
                table: "Robots");

            migrationBuilder.AddColumn<int>(
                name: "Durability",
                table: "Armors",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Durability",
                table: "Armors");

            migrationBuilder.AddColumn<int>(
                name: "CurrentHealth",
                table: "Robots",
                nullable: false,
                defaultValue: 0);
        }
    }
}
