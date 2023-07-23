using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthorBooksEntity.Migrations
{
	public class SeedData : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.InsertData(
				table: "Authors",
				columns: new[] {"Id", "FirstName", "LastName"},
				values: new object[,]
				{
					{1, "Victor", "Ajibade" },
					{2, "Segun", "Adeosun" }
				}
			
				);
		}
	}
}
