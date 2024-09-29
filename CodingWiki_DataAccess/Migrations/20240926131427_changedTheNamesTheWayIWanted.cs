using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changedTheNamesTheWayIWanted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubCategory_Id",
                table: "SubCategories",
                newName: "SubCategoryId");

            migrationBuilder.RenameColumn(
                name: "Publisher_Id",
                table: "Publishers",
                newName: "PublisherId");

            migrationBuilder.RenameColumn(
                name: "Author_Id",
                table: "Authors",
                newName: "AuthorId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubCategoryId",
                table: "SubCategories",
                newName: "SubCategory_Id");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "Publishers",
                newName: "Publisher_Id");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Authors",
                newName: "Author_Id");

            migrationBuilder.AlterColumn<int>(
                name: "LastName",
                table: "Authors",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
