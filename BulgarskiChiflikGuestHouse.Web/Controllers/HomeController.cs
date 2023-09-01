using Microsoft.AspNetCore.Mvc;

namespace BulgarskiChiflikGuestHouse.Web.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}