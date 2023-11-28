using GuestHouse.Web.Service;
using Microsoft.AspNetCore.Mvc;

namespace GuestHouse.Web.Controllers
{
	public class RoomsController : Controller
    { 
        private readonly IRoomWebService _roomWebService;

		public RoomsController(IRoomWebService roomWebService)
		{
			_roomWebService = roomWebService;
		}

		public async Task<IActionResult> GetAll()
        {
            var rooms = await _roomWebService.GetAllAsync();

            return View(rooms);
        }

        public async Task<IActionResult> GetById(Guid roomId)
        {
            var room = await _roomWebService.GetByIdAsync(roomId);

            return View(room);
        }
    }
}
