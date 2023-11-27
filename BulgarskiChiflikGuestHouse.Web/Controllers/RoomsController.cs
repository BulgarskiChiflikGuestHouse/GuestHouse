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

		public async Task<IActionResult> GetAllRooms()
        {
            var rooms = await _roomWebService.GetAllRoomsAsync();

            return View(rooms);
        }

        public async Task<IActionResult> GetRoomById(Guid roomId)
        {
            var room = await _roomWebService.GetRoomByIdAsync(roomId);

            return View(room);
        }
    }
}
