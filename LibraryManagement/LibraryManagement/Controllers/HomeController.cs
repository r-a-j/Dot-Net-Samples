using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagement.Controllers
{
    public class HomeController : Controller
    {
		// GET: Home
		public ActionResult Index()
		{

			ViewBag.Test = "Test ViewBag";
			ViewData["Test"] = "Test ViewData";
			TempData["TestTemp"] = "Test TempData";
            return View();
        }

		//// Adding data to database
		//[HttpGet]
		//public ActionResult AddToDatabase(BookViewModel model)
		//{
		//	model.AddBookToDatabase(model);
		//	return PartialView("_EditDatabase");			
		//}

		// Adding data to database
		
		public ActionResult AddToDatabase()
		{
			//model.AddBookToDatabase(model);
			return PartialView("_EditDatabase",new BookViewModel());
		}

		// For getting all the data from database to display on 
		public ActionResult DisplayFormDatabase()
		{
			BookViewModel model = new BookViewModel();
			model.lstBook = model.GetBookList();
			return View(model);
		}

		// For displaying data from database into the form  for editing
		public ViewResult EditDatabase(decimal? id)
		{
			BookViewModel model = new BookViewModel();
			model = model.GetBookById(id);
			return View(model);		
		}

	}
}