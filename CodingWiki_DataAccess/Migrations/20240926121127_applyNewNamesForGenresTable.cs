using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class applyNewNamesForGenresTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "tb_genres");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "tb_genres",
                newName: "name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_genres",
                table: "tb_genres",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_genres",
                table: "tb_genres");

            migrationBuilder.RenameTable(
                name: "tb_genres",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Categories",
                newName: "GenreName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Categories",
                column: "GenreId");
        }
    }
}
