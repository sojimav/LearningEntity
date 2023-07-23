
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AuthorBooksEntity.Models
{
	public class PublisherDBContext : DbContext
	{
		public PublisherDBContext(DbContextOptions<PublisherDBContext> options) : base(options) 
		{

		}

		public DbSet<Author> Authors { get; set; }
		public DbSet<Book> Books { get; set; }	

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=localHost;Database=BooksEntity;Integrated Security=True;Trust Server Certificate=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Author>().HasData(
			new Author
			{
				Id = 1,
				FirstName = "Victor",
				LastName = "Ajibade",

			}

			);


		}
	}
}
