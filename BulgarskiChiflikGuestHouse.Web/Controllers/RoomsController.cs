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

        public IActionResult OurRooms()
        {
            var rooms = _roomService.GetAllRooms();

            var roomss = new List<RoomViewModel>
            {
                new RoomViewModel
                {
                    Id = 1,
                    Number = 1,
                    Type = "Bedroom",
                    Beds = 2,
                    Price = 65,
                    ImagesSource =
                    {
                        "~/img/room-1.jpg",
                        "~/img/room-2.jpg",
                    },
                    HasBath = true,
                    HasWiFi = true,
                    Description = "Sandart bedroom with two beds, wifi and a bathroom.",
                    Rating = 5
                },
                new RoomViewModel
                {
                    Id = 2,
                    Number = 2,
                    Type = "Single beds",
                    Beds = 2,
                    Price = 35,
                    ImagesSource =
                    {
                        "~/img/room-2.jpg",
                        "~/img/room-1.jpg",
                        "~/img/room-3.jpg",
                        "~/img/room-2.jpg"
                    },
                    HasBath = true,
                    HasWiFi = false,
                    Description = "Standart room with two single beds with a bathroom.",
                    Rating = 4
                },
                new RoomViewModel
                {
                    Id = 3,
                    Number = 3,
                    Type = "Apartment",
                    Beds = 4,
                    Price = 100,
                    ImagesSource =
                    {
                        "~/img/room-3.jpg",
                    },
                    HasBath = false,
                    HasWiFi = true,
                    Description = "Two room apartment with four beds, wifi, but without a bathroom.",
                    Rating = 3
                },
                new RoomViewModel
                {
                    Id = 4,
                    Number = 4,
                    Type = "Big Bedroom",
                    Beds = 1,
                    Price = 85,
                    ImagesSource =
                    {
                        "~/img/room-1.jpg",
                        "~/img/room-2.jpg",
                        "~/img/room-3.jpg",
                        "~/img/room-2.jpg",
                        "~/img/room-3.jpg"
                    },
                    HasBath = false,
                    HasWiFi = false,
                    Description = "Big bedroom with one king size bed, without wifi and bathroom.",
                    Rating = 2
                }
            };

            return View(rooms);
        }

        public IActionResult RoomDetails(RoomViewModel room)
        {
            return View(room);
        }
    }
}
