namespace GuestHouse.Web.Models
{
    public class RoomModel
    {
		//public Guid Id { get; set; }

		public int Number { get; set; }

		public string? Type { get; set; }

		public int Beds { get; set; }

		public decimal Price { get; set; }

		public string ImageSource { get; set; }

		public bool HasBath { get; set; }

		public bool HasWiFi { get; set; }

		public string Description { get; set; }

		public int Rating { get; set; }
	}
}
