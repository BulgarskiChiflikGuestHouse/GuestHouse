namespace GuestHouse.DAL.Models
{
	public class Room
	{
		public int Id { get; set; }

        public int Number { get; set; }

        public string Type { get; set; }

        public int Beds { get; set; }

        public ICollection<Amenity>? Amenities { get; set; }
    }
}
