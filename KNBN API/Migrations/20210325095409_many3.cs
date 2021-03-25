using Microsoft.EntityFrameworkCore.Migrations;

namespace KNBN_API.Migrations
{
    public partial class many3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Card_Labels_Cards_CardId",
                table: "Card_Labels");

            migrationBuilder.DropForeignKey(
                name: "FK_Card_Members_Cards_CardId",
                table: "Card_Members");

            migrationBuilder.DropIndex(
                name: "IX_Card_Members_CardId",
                table: "Card_Members");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Card_Labels",
                table: "Card_Labels");

            migrationBuilder.DropIndex(
                name: "IX_Card_Labels_CardId",
                table: "Card_Labels");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Card_Members");

            migrationBuilder.RenameColumn(
                name: "Card_LabelsId",
                table: "Card_Labels",
                newName: "LabelId");

            migrationBuilder.AlterColumn<int>(
                name: "CardId",
                table: "Card_Labels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LabelId",
                table: "Card_Labels",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Card_Labels",
                table: "Card_Labels",
                columns: new[] { "CardId", "LabelId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Card_Labels_Cards_CardId",
                table: "Card_Labels",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "CardId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Card_Labels_Cards_CardId",
                table: "Card_Labels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Card_Labels",
                table: "Card_Labels");

            migrationBuilder.RenameColumn(
                name: "LabelId",
                table: "Card_Labels",
                newName: "Card_LabelsId");

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "Card_Members",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardId",
                table: "Card_Labels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Card_LabelsId",
                table: "Card_Labels",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Card_Labels",
                table: "Card_Labels",
                column: "Card_LabelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Card_Members_CardId",
                table: "Card_Members",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Card_Labels_CardId",
                table: "Card_Labels",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Card_Labels_Cards_CardId",
                table: "Card_Labels",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "CardId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Card_Members_Cards_CardId",
                table: "Card_Members",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "CardId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
