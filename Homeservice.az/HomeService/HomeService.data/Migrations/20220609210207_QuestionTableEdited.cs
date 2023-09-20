using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeService.data.Migrations
{
    public partial class QuestionTableEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionLanguage_Questions_QuestionId",
                table: "QuestionLanguage");

            migrationBuilder.DropColumn(
                name: "QuesttionId",
                table: "QuestionLanguage");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "QuestionLanguage",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionLanguage_Questions_QuestionId",
                table: "QuestionLanguage",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionLanguage_Questions_QuestionId",
                table: "QuestionLanguage");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "QuestionLanguage",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "QuesttionId",
                table: "QuestionLanguage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionLanguage_Questions_QuestionId",
                table: "QuestionLanguage",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
