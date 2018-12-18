using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookInsertOperation.Models;

namespace BookInsertOperation.Controllers
{
	public class HomeController : Controller
	{

		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Index(BookModel model)
		{
			using (var db = new BookEntities())
			{
				Book data = new Book();
				data.BookTitle = model.BookTitle;
				data.BookAuthor = model.BookAuthor;
				data.BookQuantity = model.BookQuantity;
				db.Books.Add(data);
				db.SaveChanges();
			}

			return View("Index");
		}

		

		
	}
}