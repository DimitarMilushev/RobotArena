using Microsoft.EntityFrameworkCore.Migrations;

namespace RobotArena.Data.Migrations
{
    public partial class DamageReduction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DamageReduction",
                table: "Robots");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "DamageReduction",
                table: "Robots",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
