﻿using GuestHouse.DAL.Models;
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
            var rooms = await _guestHouseDbContext.Rooms.ToListAsync();

            return rooms;
        }

        public async Task<Room> GetRommByIdAsync(Guid roomId)
        {
            var room = await _guestHouseDbContext.Rooms.FirstOrDefaultAsync(r => r.Id == roomId);

            return room;
        }

        public async Task<string> GetRoomTypeAsync(Guid roomId)
        {
            var roomType = await _guestHouseDbContext.RoomTypes.FirstOrDefaultAsync(r => r.Id == roomId);

            return roomType.Name;
        }
    }
}