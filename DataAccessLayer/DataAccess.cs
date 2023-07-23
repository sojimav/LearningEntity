//using AuthorBooksEntity.Models;

//namespace AuthorBooksEntity.DataAccessLayer
//{
//	public class DataAccess
//	{
//		public static void WriteToBase()
//		{
//			using(var context = new PublisherContext())
//			{
//				context.Authors.Add(new Author
//				{
//					FirstName = "Juliet", 
//					LastName = "Mayers",
//					Books = new List<Book>
//					{
//						new Book
//						{
//							Title = "Dream Big",
//							PublishDate = new DateTime(1996, 2, 5),
//							BasePrice = 700,
							
//						}
//					}
//				});

//				context.SaveChanges();
//			}
//		}
//	}
//}
