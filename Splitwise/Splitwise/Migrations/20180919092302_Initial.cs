using Microsoft.EntityFrameworkCore.Migrations;

namespace Splitwise.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "sattleUps");

            migrationBuilder.RenameColumn(
                name: "SattleupId",
                table: "sattleUps",
                newName: "SattleUpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SattleUpId",
                table: "sattleUps",
                newName: "SattleupId");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "sattleUps",
                nullable: false,
                defaultValue: 0);
        }
    }
}
