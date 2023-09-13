using Microsoft.AspNetCore.Mvc;

namespace GuestHouse.Web.Controllers
{
    public class RooomsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
