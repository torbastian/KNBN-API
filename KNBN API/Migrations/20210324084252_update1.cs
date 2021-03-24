using Microsoft.EntityFrameworkCore.Migrations;

namespace KNBN_API.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Card_Members_Groups_GroupId",
                table: "Card_Members");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Card_Members",
                newName: "Board_MembersId");

            migrationBuilder.RenameIndex(
                name: "IX_Card_Members_GroupId",
                table: "Card_Members",
                newName: "IX_Card_Members_Board_MembersId");

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Tables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Labels",
                columns: table => new
                {
                    LabelsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labels", x => x.LabelsId);
                });

            migrationBuilder.CreateTable(
                name: "Card_Labels",
                columns: table => new
                {
                    Card_LabelsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardId = table.Column<int>(type: "int", nullable: true),
                    LabelsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card_Labels", x => x.Card_LabelsId);
                    table.ForeignKey(
                        name: "FK_Card_Labels_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "CardId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Card_Labels_Labels_LabelsId",
                        column: x => x.LabelsId,
                        principalTable: "Labels",
                        principalColumn: "LabelsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Card_Labels_CardId",
                table: "Card_Labels",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Card_Labels_LabelsId",
                table: "Card_Labels",
                column: "LabelsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Card_Members_Board_Members_Board_MembersId",
                table: "Card_Members",
                column: "Board_MembersId",
                principalTable: "Board_Members",
                principalColumn: "Board_MembersId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Card_Members_Board_Members_Board_MembersId",
                table: "Card_Members");

            migrationBuilder.DropTable(
                name: "Card_Labels");

            migrationBuilder.DropTable(
                name: "Labels");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "Board_MembersId",
                table: "Card_Members",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Card_Members_Board_MembersId",
                table: "Card_Members",
                newName: "IX_Card_Members_GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Card_Members_Groups_GroupId",
                table: "Card_Members",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
