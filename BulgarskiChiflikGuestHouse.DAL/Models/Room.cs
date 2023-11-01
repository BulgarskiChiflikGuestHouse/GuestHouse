using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuestHouse.DAL.Models
{
	public class Room
	{
		public Guid Id { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string? Description { get; set; }

        [ForeignKey(nameof(RoomType))]
        public Guid RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }

        public IEnumerable<ImageSource> ImagesSources { get; set; } 

        public virtual ICollection<Amenity> Amenities { get; set; } = new List<Amenity>();
    }
}
