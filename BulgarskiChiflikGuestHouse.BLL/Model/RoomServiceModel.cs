using GuestHouse.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GuestHouse.BLL.Model
{

    public class RoomServiceModel
    {
        public Guid Id { get; set; }

        public string Number{ get; set; }

        public int Capacity { get; set; }

        public decimal Price { get; set; }

        public string? Description { get; set; }

        public Guid RoomTypeId { get; set; }

        public string RoomTypeName { get; set; }

        public IEnumerable<ImageSource> ImagesSources { get; set; }

        public virtual ICollection<Amenity> Amenities { get; set; } = new HashSet<Amenity>();
    }
}