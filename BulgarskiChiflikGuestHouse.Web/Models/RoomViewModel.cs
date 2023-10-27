using GuestHouse.BLL.Model;

namespace GuestHouse.Web.Models
{
    public class RoomViewModel
    {
		public Guid Id { get; set; }

        public string Number { get; set; }

		public Guid RoomTypeId { get; set; }

		public string RoomTypeName { get; set; }

		public int Capacity { get; set; }

		public decimal Price { get; set; }

		public List<ImageSourceServiceModel> ImagesSource { get; set; }
		
		public ICollection<AmenityServiceModel> Amenities { get; set; } = new HashSet<AmenityServiceModel>();

		public string Description { get; set; }
	}
}
