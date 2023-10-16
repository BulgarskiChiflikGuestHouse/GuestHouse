namespace GuestHouse.DAL.Models
{
	public class Room
	{
		public Guid Id { get; set; }

        public int Number { get; set; }

        public string? Type { get; set; }

        public int Beds { get; set; }

        public Guid AmenityId { get; set; }

        public ICollection<Amenity>? Amenities { get; set; }
    }
}
