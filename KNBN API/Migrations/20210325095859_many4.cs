using Microsoft.EntityFrameworkCore.Migrations;

namespace KNBN_API.Migrations
{
    public partial class many4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Group_Members_Users_UserId",
                table: "Group_Members");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Group_Members",
                table: "Group_Members");

            migrationBuilder.RenameColumn(
                name: "Group_MemberId",
                table: "Group_Members",
                newName: "GropId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Group_Members",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GropId",
                table: "Group_Members",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Group_Members",
                table: "Group_Members",
                columns: new[] { "GropId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Members_Users_UserId",
                table: "Group_Members",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Group_Members_Users_UserId",
                table: "Group_Members");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Group_Members",
                table: "Group_Members");

            migrationBuilder.RenameColumn(
                name: "GropId",
                table: "Group_Members",
                newName: "Group_MemberId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Group_Members",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Group_MemberId",
                table: "Group_Members",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Group_Members",
                table: "Group_Members",
                column: "Group_MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Members_Users_UserId",
                table: "Group_Members",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
