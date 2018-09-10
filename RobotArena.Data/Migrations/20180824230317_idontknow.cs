using Microsoft.EntityFrameworkCore.Migrations;

namespace RobotArena.Data.Migrations
{
    public partial class idontknow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Weapons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Armors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_UserId",
                table: "Weapons",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Armors_UserId",
                table: "Armors",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Armors_AspNetUsers_UserId",
                table: "Armors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_AspNetUsers_UserId",
                table: "Weapons",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armors_AspNetUsers_UserId",
                table: "Armors");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_AspNetUsers_UserId",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Weapons_UserId",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Armors_UserId",
                table: "Armors");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Armors");
        }
    }
}
