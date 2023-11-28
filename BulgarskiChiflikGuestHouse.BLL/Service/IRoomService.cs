using GuestHouse.BLL.Model;

namespace GuestHouse.BLL.Service
{

    public interface IRoomService
    {
        public Task<RoomServiceModel> GetByIdAsync(Guid roomId);

        public Task<List<RoomServiceModel>> GetAllAsync();
    }
}