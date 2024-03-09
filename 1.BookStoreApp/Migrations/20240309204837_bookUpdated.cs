using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.BookStoreApp.Migrations
{
    /// <inheritdoc />
    public partial class bookUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PusblisherId",
                table: "Books",
                newName: "PublisherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "Books",
                newName: "PusblisherId");
        }
    }
}
