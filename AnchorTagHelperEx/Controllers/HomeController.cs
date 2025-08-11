using AnchorTagHelperEx.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.Design;

namespace AnchorTagHelperEx.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}


		[HttpGet]
		public IActionResult Create()
		{
			var cities = City.GetCities();
			ViewBag.Cities = new SelectList(cities, "CityID", "CityName");
			return View();
		}

		[HttpPost]
		public IActionResult Create(Customer rec)
		{
			if (ModelState.IsValid)
			{

				//if (rec.CreditLimit % 2 != 0)
				//{
				//	//ModelState.AddModelError("CreditLimit","Credit Limit Should be Even!");

				//	ModelState.AddModelError("", "Credit Limit Should be Even!");

				//	return View(rec);
				//}

				//save code 
				return RedirectToAction("Index");
			}

			var cities = City.GetCities();
			ViewBag.Cities = new SelectList(cities, "CityID", "CityName");
			return View(rec);
		}

		public IActionResult About()
		{
			return View();
		}
	}
}
