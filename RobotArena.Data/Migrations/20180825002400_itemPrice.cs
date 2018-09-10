using Microsoft.EntityFrameworkCore.Migrations;

namespace RobotArena.Data.Migrations
{
    public partial class itemPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gems_Armors_ArmorId",
                table: "Gems");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Weapons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ArmorId",
                table: "Gems",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Gems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Armors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Gems_Armors_ArmorId",
                table: "Gems",
                column: "ArmorId",
                principalTable: "Armors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gems_Armors_ArmorId",
                table: "Gems");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Gems");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Armors");

            migrationBuilder.AlterColumn<int>(
                name: "ArmorId",
                table: "Gems",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Gems_Armors_ArmorId",
                table: "Gems",
                column: "ArmorId",
                principalTable: "Armors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
