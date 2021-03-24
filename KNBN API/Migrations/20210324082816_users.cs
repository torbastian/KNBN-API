using Microsoft.EntityFrameworkCore.Migrations;

namespace KNBN_API.Migrations
{
    public partial class users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Card_Members_Users_UserId",
                table: "Card_Members");

            migrationBuilder.DropIndex(
                name: "IX_Card_Members_UserId",
                table: "Card_Members");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Card_Members");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Card_Members",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Card_Members_UserId",
                table: "Card_Members",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Card_Members_Users_UserId",
                table: "Card_Members",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
