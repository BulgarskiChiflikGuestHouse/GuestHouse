using GuestHouse.DAL.Models;

namespace GuestHouse.DAL.Repository
{
    public interface IRepository
    {
        public Room GetRommById(int roomId);

        public List<Room> GetAllRooms();
    }
}