using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addFluentOneToOneMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "FluentBookDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FluentBookDetail_BookId",
                table: "FluentBookDetail",
                column: "BookId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBookDetail_FluentBooks_BookId",
                table: "FluentBookDetail",
                column: "BookId",
                principalTable: "FluentBooks",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentBookDetail_FluentBooks_BookId",
                table: "FluentBookDetail");

            migrationBuilder.DropIndex(
                name: "IX_FluentBookDetail_BookId",
                table: "FluentBookDetail");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "FluentBookDetail");
        }
    }
}
