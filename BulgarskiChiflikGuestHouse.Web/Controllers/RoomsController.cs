using GuestHouse.BLL.Model;
using GuestHouse.BLL.Service;
using GuestHouse.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GuestHouse.Web.Controllers
{
    public class RoomsController : Controller
    {
        private readonly IRoomService _roomService;

        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public async Task<IActionResult> OurRooms()
        {
            var serviceRooms = await _roomService.GetAllRoomsAsync();

            var viewRooms = serviceRooms.Select(room => new RoomViewModel
            {
                Id = room.Id,
                RoomTypeId = room.RoomTypeId,
                RoomTypeName = room.RoomTypeName,
                Number = room.Number,
                Capacity = room.Capacity,
                Description = room.Description,
                Price = room.Price,
                ImagesSource = room.ImagesSources.Select(image => new ImageSourceServiceModel
                {
                    Id = image.Id,
                    Alt = image.Alt,
                    Path = image.Path,
                    RoomId = image.RoomId
                }).ToList(),
                Amenities = room.Amenities.Select(amenity => new AmenityServiceModel
                {
                    Id = amenity.Id,
                    Name = amenity.Name
                }).ToList(),
            }).ToList();

            return View(viewRooms);
        }
    }
}
