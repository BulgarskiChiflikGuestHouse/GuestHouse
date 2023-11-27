using GuestHouse.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace GuestHouse.DAL.Repository
{
	public class Repository : IRepository
    {
        private readonly GuestHouseDbContext _guestHouseDbContext;

        public Repository(GuestHouseDbContext guestHouseDbContext)
        {
            _guestHouseDbContext = guestHouseDbContext;
        }

        public async Task<List<Room>> GetAllRoomsAsync()
        {
            var rooms = await _guestHouseDbContext.Rooms
                .Include(room => room.ImagesSources)
                .Include(room => room.RoomType)
                .Include(room => room.Amenities)
                .ToListAsync();

            return rooms;
        }

        public async Task<Room> GetRoomByIdAsync(Guid roomId)
        {
            var room = await _guestHouseDbContext.Rooms
                .Include(room => room.ImagesSources)
                .Include(room => room.RoomType)
                .Include(room => room.Amenities)
                .FirstOrDefaultAsync(r => r.Id == roomId);

            return room;
        }

        public async Task<string> GetRoomTypeAsync(Guid roomId)
        {
            var roomType = await _guestHouseDbContext.RoomTypes
                .FirstOrDefaultAsync(r => r.Id == roomId);

            return roomType.Name;
        }
    }
}