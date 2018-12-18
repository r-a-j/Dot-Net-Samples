using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleCRUD.Models;


namespace SimpleCRUD.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		[HttpPost]
		public ActionResult Create(BookViewModel model)
		{
			using (var db = new BookEntities())
			{
				tblBook data = new tblBook();
				data.BookTitle = model.BookTitle;
				data.BookAuthor = model.BookAuthor;
				data.BookQuantity = model.BookQuantity;
				db.tblBook.Add(data);
				db.SaveChanges();
			}
			return RedirectToAction("ViewFromDb");
		}	

		public ActionResult ViewFromDb()
		{
			var model = new BookViewModel();
			model.lstBook = model.GetBookDetails();
			return View(model);
		}

	}
}