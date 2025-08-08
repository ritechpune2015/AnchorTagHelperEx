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

		public IActionResult About()
		{
			return View();
		}
	}
}
