//using AuthorBooksEntity.Models;
//using AuthorBooksEntity.DataAccessLayer;

//namespace AuthorBooksEntity.Middleware
//{
//	public class DataAccessMiddleWare : IMiddleware
//	{
		
//		public async Task InvokeAsync(HttpContext context, RequestDelegate next)
//		{
//			using(PublisherContext cont = new PublisherContext())
//			{
//				cont.Database.EnsureCreated();
//			}
//			await Task.Delay(300);

//			DataAccess.WriteToBase();
//			await Task.CompletedTask;


//			await next(context);
	
//		}


//		//public void GetAuthors()
//		//{
//		//	using(var cont = new PublisherContext())
//		//	{
//		//		cont.Authors.ToList().ForEach(x => { });
//		//	}
//		//}
//	}

//}
