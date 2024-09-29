using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addMappingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthorMap_Authors_AuthorId",
                table: "BookAuthorMap");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthorMap_Books_BookId",
                table: "BookAuthorMap");

            migrationBuilder.DropForeignKey(
                name: "FK_FluentBookAuthorMap_FluentAuthors_AuthorId",
                table: "FluentBookAuthorMap");

            migrationBuilder.DropForeignKey(
                name: "FK_FluentBookAuthorMap_FluentBooks_BookId",
                table: "FluentBookAuthorMap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FluentBookAuthorMap",
                table: "FluentBookAuthorMap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthorMap",
                table: "BookAuthorMap");

            migrationBuilder.RenameTable(
                name: "FluentBookAuthorMap",
                newName: "FluentBookAuthorMaps");

            migrationBuilder.RenameTable(
                name: "BookAuthorMap",
                newName: "BookAuthorMaps");

            migrationBuilder.RenameIndex(
                name: "IX_FluentBookAuthorMap_BookId",
                table: "FluentBookAuthorMaps",
                newName: "IX_FluentBookAuthorMaps_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthorMap_BookId",
                table: "BookAuthorMaps",
                newName: "IX_BookAuthorMaps_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FluentBookAuthorMaps",
                table: "FluentBookAuthorMaps",
                columns: new[] { "AuthorId", "BookId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthorMaps",
                table: "BookAuthorMaps",
                columns: new[] { "AuthorId", "BookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthorMaps_Authors_AuthorId",
                table: "BookAuthorMaps",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthorMaps_Books_BookId",
                table: "BookAuthorMaps",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBookAuthorMaps_FluentAuthors_AuthorId",
                table: "FluentBookAuthorMaps",
                column: "AuthorId",
                principalTable: "FluentAuthors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBookAuthorMaps_FluentBooks_BookId",
                table: "FluentBookAuthorMaps",
                column: "BookId",
                principalTable: "FluentBooks",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthorMaps_Authors_AuthorId",
                table: "BookAuthorMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthorMaps_Books_BookId",
                table: "BookAuthorMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_FluentBookAuthorMaps_FluentAuthors_AuthorId",
                table: "FluentBookAuthorMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_FluentBookAuthorMaps_FluentBooks_BookId",
                table: "FluentBookAuthorMaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FluentBookAuthorMaps",
                table: "FluentBookAuthorMaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthorMaps",
                table: "BookAuthorMaps");

            migrationBuilder.RenameTable(
                name: "FluentBookAuthorMaps",
                newName: "FluentBookAuthorMap");

            migrationBuilder.RenameTable(
                name: "BookAuthorMaps",
                newName: "BookAuthorMap");

            migrationBuilder.RenameIndex(
                name: "IX_FluentBookAuthorMaps_BookId",
                table: "FluentBookAuthorMap",
                newName: "IX_FluentBookAuthorMap_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthorMaps_BookId",
                table: "BookAuthorMap",
                newName: "IX_BookAuthorMap_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FluentBookAuthorMap",
                table: "FluentBookAuthorMap",
                columns: new[] { "AuthorId", "BookId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthorMap",
                table: "BookAuthorMap",
                columns: new[] { "AuthorId", "BookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthorMap_Authors_AuthorId",
                table: "BookAuthorMap",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthorMap_Books_BookId",
                table: "BookAuthorMap",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBookAuthorMap_FluentAuthors_AuthorId",
                table: "FluentBookAuthorMap",
                column: "AuthorId",
                principalTable: "FluentAuthors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBookAuthorMap_FluentBooks_BookId",
                table: "FluentBookAuthorMap",
                column: "BookId",
                principalTable: "FluentBooks",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
