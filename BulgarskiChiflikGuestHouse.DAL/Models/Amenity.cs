namespace GuestHouse.DAL.Models
{
	public class Amenity
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

        public Guid RoomId { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
