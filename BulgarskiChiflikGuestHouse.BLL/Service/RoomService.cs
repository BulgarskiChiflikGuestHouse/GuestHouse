using GuestHouse.BLL.Model;
using GuestHouse.DAL.Models;
using GuestHouse.DAL.Repository;

namespace GuestHouse.BLL.Service
{

    public class RoomService : IRoomService
    {
        private readonly IRepository _repository;

        public RoomService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<RoomServiceModel>> GetAllRoomsAsync()
        {
            var dbRooms = await _repository.GetAllRoomsAsync();

            if (dbRooms is null)
            {
                throw new KeyNotFoundException("No rooms found.");
            }

            var serviceRooms = dbRooms.Select(room => new RoomServiceModel
            {
                Id = room.Id,
                Number = room.Number,
                RoomTypeId = room.RoomTypeId,
                Capacity = room.Capacity,
                Price = room.Price,
                Description = room.Description,
                ImagesSources = room.ImagesSources,
                Amenities = room.Amenities
            })
            .ToList();

            return serviceRooms;
        }

        public async Task<RoomServiceModel> GetRommByIdAsync(Guid roomId)
        {
            var dbroom = await _repository.GetRommByIdAsync(roomId);

            var serviceroom = new RoomServiceModel
            {
                Id = dbroom.Id,
                Number = dbroom.Number,
                RoomTypeId = dbroom.RoomTypeId,
                RoomTypeName = dbroom.RoomType.Name,
                Capacity = dbroom.Capacity,
                Price = dbroom.Price,
                Description = dbroom.Description,
                ImagesSources = dbroom.ImagesSources,
                Amenities = dbroom.Amenities
            };

            return serviceroom;
        }
    }
}