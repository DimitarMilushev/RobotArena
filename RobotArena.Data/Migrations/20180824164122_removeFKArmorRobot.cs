using Microsoft.EntityFrameworkCore.Migrations;

namespace RobotArena.Data.Migrations
{
    public partial class removeFKArmorRobot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armors_Robots_RobotId",
                table: "Armors");

            migrationBuilder.AlterColumn<int>(
                name: "RobotId",
                table: "Armors",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Armors_Robots_RobotId",
                table: "Armors",
                column: "RobotId",
                principalTable: "Robots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armors_Robots_RobotId",
                table: "Armors");

            migrationBuilder.AlterColumn<int>(
                name: "RobotId",
                table: "Armors",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Armors_Robots_RobotId",
                table: "Armors",
                column: "RobotId",
                principalTable: "Robots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
