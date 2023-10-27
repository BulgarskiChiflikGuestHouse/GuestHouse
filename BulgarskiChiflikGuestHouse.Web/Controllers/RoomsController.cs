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

            var viewRooms = serviceRooms.Select(async r => new RoomViewModel
            {
                Id = r.Id,
                RoomTypeId = r.RoomTypeId,
                RoomTypeName = await _roomService.GetRoomTypeAsync(r.RoomTypeId),
                Number = r.Number,
                Capacity = r.Capacity,
                Description = r.Description,
                Price = r.Price,
                Amenities = (ICollection<AmenityServiceModel>)r.Amenities.Select(a => new AmenityViewModel
                {
                    Id = a.Id,
                    Name = a.Name
                }),
                ImagesSource = (List<ImageSourceServiceModel>)r.ImagesSources.Select(i => new ImageSourceViewModel
                {
                    Id=i.Id,
                    Alt = i.Alt,
                    Path = i.Path,
                    RoomId = i.RoomId
                })
            });

            return View(viewRooms);
        }

        public async Task<IActionResult> RoomDetails(Guid roomId)
        {
            var serviceRoom = await _roomService.GetRommByIdAsync(roomId);

            return View(serviceRoom);
        }
    }
}
