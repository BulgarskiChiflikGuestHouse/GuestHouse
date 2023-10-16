using GuestHouse.BLL.Model;
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

        public List<RoomServiceModel> GetAllRooms()
        {
            //отиди в ДАЛ и вземи всички стаи.
            // провери дали си логнат
            // ако си логнат като обикновен, дай само активни стаи
            // ако си админ, дай всички стаи дори и деактивирани

            var dbRooms = _repository.GetAllRooms();

            var serviceRooms = dbRooms.Select(x => new RoomServiceModel
            {
                Id = x.Id,
                Number = x.Number,
            })
            .ToList();

            return serviceRooms;
        }

        public RoomServiceModel GetRommById(int roomId)
        {
            //отиди в ДАЛ и вземи стая по ид.
            return null;
        }
    }
}