using GuestHouse.DAL.Models;

namespace GuestHouse.DAL.Repository
{
    public class Repository : IRepository
    {
        private readonly GuestHouseDbContext _guestHouseDbContext;

        public Repository(GuestHouseDbContext guestHouseDbContext)
        {
            _guestHouseDbContext = guestHouseDbContext;
        }

        public List<Room> GetAllRooms()
        {
            var rooms = _guestHouseDbContext.Rooms.ToList();

            return rooms;
        }

        public Room GetRommById(int roomId)
        {
            throw new NotImplementedException();
        }
    }
}