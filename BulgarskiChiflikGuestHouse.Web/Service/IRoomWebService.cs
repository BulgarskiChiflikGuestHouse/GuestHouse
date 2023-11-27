using GuestHouse.Web.Models;

namespace GuestHouse.Web.Service
{
	public interface IRoomWebService
	{
		Task<List<RoomViewModel>> GetAllRoomsAsync();

		Task<RoomViewModel> GetRoomByIdAsync(Guid roomId);
	}
}
