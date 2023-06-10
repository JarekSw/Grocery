using Grocery.Data;
using Grocery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Grocery.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			var produkty = ProductsPL.Produkty;
			return View(produkty);
		}
		public IActionResult IndexEng()
		{
			var produkty = ProductsENG.Produkty;
			return View(produkty);
		}

	

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}