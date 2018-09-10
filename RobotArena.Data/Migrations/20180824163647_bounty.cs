using Microsoft.EntityFrameworkCore.Migrations;

namespace RobotArena.Data.Migrations
{
    public partial class bounty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Bounty",
                table: "Creeps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Armors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bounty",
                table: "Creeps");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Armors");
        }
    }
}
