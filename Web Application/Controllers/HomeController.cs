using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureBootCampV1.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var bodyBackgroundColor = "#CEF6CE";
			var machineName = Environment.MachineName;

			switch(machineName)
			{
				case "EUS-WEB01":
					bodyBackgroundColor = "#FFE1F0";
					break;
				case "EUS-WEB02":
					bodyBackgroundColor = "#CECEF6";
					break;
                case "WUS-WEB02":
					bodyBackgroundColor = "#ffffeb";
					break;
				default:
					break;
			}

			ViewBag.BodyBackgroundColor = bodyBackgroundColor;

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
	}
}