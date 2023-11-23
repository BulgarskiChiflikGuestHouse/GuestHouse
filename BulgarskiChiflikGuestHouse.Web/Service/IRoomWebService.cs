using GuestHouse.Web.Models;

namespace GuestHouse.Web.Service
{
	public interface IRoomWebService
	{
		Task<List<RoomViewModel>> GetAllRoomsAsync();
	}
}
