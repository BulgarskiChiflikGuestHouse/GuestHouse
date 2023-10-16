namespace GuestHouse.Web.Models
{
    public class RoomViewModel
    {
		public int Id { get; set; }

        public int Number { get; set; }

		public string? Type { get; set; }

		public int Beds { get; set; }

		public decimal Price { get; set; }

		public List<string> ImagesSource { get; set; } = new List<string>();

		public bool HasBath { get; set; }

		public bool HasWiFi { get; set; }

		public string Description { get; set; }

		public int Rating { get; set; }
	}
}
