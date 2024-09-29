using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addManyToManyRelationsManual : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FluentBookAuthorMap",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentBookAuthorMap", x => new { x.AuthorId, x.BookId });
                    table.ForeignKey(
                        name: "FK_FluentBookAuthorMap_FluentAuthors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "FluentAuthors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FluentBookAuthorMap_FluentBooks_BookId",
                        column: x => x.BookId,
                        principalTable: "FluentBooks",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FluentBookAuthorMap_BookId",
                table: "FluentBookAuthorMap",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FluentBookAuthorMap");
        }
    }
}
