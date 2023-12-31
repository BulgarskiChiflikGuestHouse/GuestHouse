﻿using GuestHouse.DAL.Models;

namespace GuestHouse.DAL.Repository
{
    public interface IRepository
    {
        public Task<Room> GetRoomByIdAsync(Guid roomId);

        public Task<List<Room>> GetAllRoomsAsync();

        public Task<string> GetRoomTypeAsync(Guid roomId);
    }
}