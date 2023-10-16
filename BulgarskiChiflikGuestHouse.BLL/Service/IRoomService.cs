using GuestHouse.BLL.Model;

namespace GuestHouse.BLL.Service
{

    public interface IRoomService
    {
        public RoomServiceModel GetRommById(int roomId);

        public List<RoomServiceModel> GetAllRooms();
    }
}