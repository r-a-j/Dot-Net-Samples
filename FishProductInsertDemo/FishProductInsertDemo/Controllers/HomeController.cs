using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FishProductInsertDemo.Models;

namespace FishProductInsertDemo.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Index(FishViewModel model)
		{
			using (var db = new FishDemoEntities())
			{
				var data = new Fish();
				data.FishName = model.FishName;
				data.FishType = model.FishType;
				data.FishQuantity = model.FishQuantity;
				db.Fish.Add(data);
				db.SaveChanges();
				
				
			}
				return View("Index");
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
	}
}