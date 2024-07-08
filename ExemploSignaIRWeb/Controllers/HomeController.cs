using Microsoft.AspNetCore.Mvc;

namespace ExemploSignaIRWeb.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index() 
		{
			return View();
		}
	}
}
