using Microsoft.EntityFrameworkCore.Migrations;

namespace KNBN_API.Migrations
{
    public partial class GetSetFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Labels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Labels",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Labels");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Labels");
        }
    }
}
