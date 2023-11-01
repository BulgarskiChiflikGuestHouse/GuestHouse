using GuestHouse.BLL.Model;

namespace GuestHouse.BLL.Service
{

    public interface IRoomService
    {
        public Task<RoomServiceModel> GetRommByIdAsync(Guid roomId);

        public Task<List<RoomServiceModel>> GetAllRoomsAsync();
    }
}