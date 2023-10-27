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

            var serviceRooms = dbRooms.Select(r => new RoomServiceModel
            {
                Id = r.Id,
                Number = r.Number,
                RoomTypeId = r.RoomTypeId,
                Capacity = r.Capacity,
                Price = r.Price,
                Description = r.Description,
                ImagesSources = (IEnumerable<ImageSource>)r.ImagesSources.Select(i => new ImageSourceServiceModel
                {
                    Id = i.Id,
                    Path = i.Path,
                    Alt = i.Alt,
                    RoomId = i.RoomId
                }),
                Amenities = (ICollection<Amenity>)r.Amenities.Select(a => new AmenityServiceModel
                {
                    Id = a.Id,
                    Name = a.Name
                })
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
                RoomTypeName = await _repository.GetRoomTypeAsync(dbroom.RoomTypeId),
                Capacity = dbroom.Capacity,
                Price = dbroom.Price,
                Description = dbroom.Description,
                ImagesSources = dbroom.ImagesSources,
                Amenities = dbroom.Amenities
            };

            return serviceroom;
        }

        public async Task<string> GetRoomTypeAsync(Guid roomId)
        {
            var roomTypeName = await _repository.GetRoomTypeAsync(roomId);

            return roomTypeName;
        }
    }
}