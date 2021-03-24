using Microsoft.EntityFrameworkCore.Migrations;

namespace KNBN_API.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_info_Users_UserId",
                table: "User_info");

            migrationBuilder.DropIndex(
                name: "IX_User_info_UserId",
                table: "User_info");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "User_info");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "User_info",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_info_UserId",
                table: "User_info",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_info_Users_UserId",
                table: "User_info",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
