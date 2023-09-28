using GuestHouse.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GuestHouse.Web.Controllers
{
    public class RoomsController : Controller
    {
        public IActionResult Rooms()
        {
            var rooms = new List<RoomModel>
            {
                new RoomModel 
                { 
                    Number = 1,
                    Type = "Bedroom",
                    Beds = 2,
                    Price = 65,
                    ImageSource = "~/img/room-1.jpg",
                    HasBath = true,
                    HasWiFi = true,
                    Description = "Sandart bedroom with two beds, wifi and a bathroom.",
                    Rating = 5
                },
                new RoomModel
                {
                    Number = 2,
                    Type = "Single beds",
                    Beds = 2,
                    Price = 35,
                    ImageSource = "~/img/room-2.jpg",
                    HasBath = true,
                    HasWiFi = false,
                    Description = "Standart room with two single beds with a bathroom.",
                    Rating = 4
                },
                new RoomModel
                {
                    Number = 3,
                    Type = "Apartment",
                    Beds = 4,
                    Price = 100,
                    ImageSource = "~/img/room-3.jpg",
                    HasBath = false,
                    HasWiFi = true,
                    Description = "Two room apartment with four beds, wifi, but without a bathroom.",
                    Rating = 3
                },
                new RoomModel
                {
                    Number = 4,
                    Type = "Big Bedroom",
                    Beds = 1,
                    Price = 85,
                    ImageSource = "~/img/room-1.jpg",
                    HasBath = false,
                    HasWiFi = false,
                    Description = "Big bedroom with one king size bed, without wifi and bathroom.",
                    Rating = 2
                }
            };
            return View(rooms);
        }
    }
}
