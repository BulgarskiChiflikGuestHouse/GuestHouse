using GuestHouse.DAL.Models;

namespace GuestHouse.BLL.Model
{

	public class RoomServiceModel
    {
        public Guid Id { get; set; }

        public string Number{ get; set; }

        public int Capacity { get; set; }

        public decimal Price { get; set; }

        public Guid RoomTypeId { get; set; }

        public string RoomTypeName { get; set; }

        public string? Description { get; set; }

        public IEnumerable<ImageSource> ImagesSources { get; set; }

        public virtual ICollection<Amenity> Amenities { get; set; } = new HashSet<Amenity>();
    }
}