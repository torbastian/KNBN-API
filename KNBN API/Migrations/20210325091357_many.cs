using Microsoft.EntityFrameworkCore.Migrations;

namespace KNBN_API.Migrations
{
    public partial class many : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Board_Members_Groups_GroupId",
                table: "Board_Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Permission_Members_Groups_GroupId",
                table: "Permission_Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Permission_Members_Users_UserId",
                table: "Permission_Members");

            migrationBuilder.DropIndex(
                name: "IX_Permission_Members_GroupId",
                table: "Permission_Members");

            migrationBuilder.DropIndex(
                name: "IX_Board_Members_GroupId",
                table: "Board_Members");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Permission_Members");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Board_Members");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Permission_Members",
                newName: "Board_MembersId");

            migrationBuilder.RenameColumn(
                name: "Permission_MemebersId",
                table: "Permission_Members",
                newName: "Permission_MembersId");

            migrationBuilder.RenameIndex(
                name: "IX_Permission_Members_UserId",
                table: "Permission_Members",
                newName: "IX_Permission_Members_Board_MembersId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Groups",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Group_Boards",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    BoardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group_Boards", x => new { x.GroupId, x.BoardId });
                    table.ForeignKey(
                        name: "FK_Group_Boards_Boards_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Boards",
                        principalColumn: "BoardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Group_Boards_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_UserId",
                table: "Groups",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_Boards_BoardId",
                table: "Group_Boards",
                column: "BoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Users_UserId",
                table: "Groups",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Permission_Members_Board_Members_Board_MembersId",
                table: "Permission_Members",
                column: "Board_MembersId",
                principalTable: "Board_Members",
                principalColumn: "Board_MembersId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Users_UserId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Permission_Members_Board_Members_Board_MembersId",
                table: "Permission_Members");

            migrationBuilder.DropTable(
                name: "Group_Boards");

            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Groups_UserId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Groups");

            migrationBuilder.RenameColumn(
                name: "Board_MembersId",
                table: "Permission_Members",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Permission_MembersId",
                table: "Permission_Members",
                newName: "Permission_MemebersId");

            migrationBuilder.RenameIndex(
                name: "IX_Permission_Members_Board_MembersId",
                table: "Permission_Members",
                newName: "IX_Permission_Members_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Permission_Members",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Board_Members",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permission_Members_GroupId",
                table: "Permission_Members",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Board_Members_GroupId",
                table: "Board_Members",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Board_Members_Groups_GroupId",
                table: "Board_Members",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Permission_Members_Groups_GroupId",
                table: "Permission_Members",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Permission_Members_Users_UserId",
                table: "Permission_Members",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
