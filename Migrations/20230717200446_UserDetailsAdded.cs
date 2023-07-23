using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthorBooksEntity.Migrations
{
    /// <inheritdoc />
    public partial class UserDetailsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "Victor", "Ajibade" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
