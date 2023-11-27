using GuestHouse.BLL.Model;
using GuestHouse.BLL.Service;
using GuestHouse.DAL.Models;
using GuestHouse.Web.Models;

namespace GuestHouse.Web.Service
{
	public class RoomWebService : IRoomWebService
	{
		private readonly IRoomService _roomService;

		public RoomWebService(IRoomService roomService)
		{
			_roomService = roomService;
		}

		public async Task<List<RoomViewModel>> GetAllRoomsAsync()
		{
			var serviceRooms = await _roomService.GetAllRoomsAsync();

			var viewRooms = serviceRooms.Select(room => new RoomViewModel
			{
				Id = room.Id,
				Number = room.Number,
				RoomTypeName = room.RoomTypeName,
				RoomTypeId = room.RoomTypeId,
				Price = room.Price,
				Capacity = room.Capacity,
				Description = room.Description,
				Amenities = room.Amenities.Select(amenity => new AmenityServiceModel
				{
					Id = amenity.Id,
					Name = amenity.Name
				})
				.ToList(),
				ImagesSource = room.ImagesSources.Select(image => new ImageSourceServiceModel
				{
					Id= image.Id,
					Alt = image.Alt,
					Path = image.Path,
					RoomId = image.RoomId
				})
				.ToList()
			}).ToList();

			return viewRooms;
		}

		public async Task<RoomViewModel> GetRoomByIdAsync(Guid roomId)
		{
			var serviceRoom = await _roomService.GetRoomByIdAsync(roomId);

			var viewRoom = new RoomViewModel
			{
				Id = serviceRoom.Id,
				Number = serviceRoom.Number,
				RoomTypeName = serviceRoom.RoomTypeName,
				RoomTypeId = serviceRoom.RoomTypeId,
				Price = serviceRoom.Price,
				Capacity = serviceRoom.Capacity,
				Description = serviceRoom.Description,
				Amenities = serviceRoom.Amenities.Select(amenity => new AmenityServiceModel
				{
					Id = amenity.Id,
					Name = amenity.Name
				}).ToList(),
				ImagesSource = serviceRoom.ImagesSources.Select(image => new ImageSourceServiceModel
				{
					Id = image.Id,
					Alt = image.Alt,
					Path = image.Path,
					RoomId = image.RoomId
				}).ToList()
			};

			return viewRoom;
		}
	}
}
