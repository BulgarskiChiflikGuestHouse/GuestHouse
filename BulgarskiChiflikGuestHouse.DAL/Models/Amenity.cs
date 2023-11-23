using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuestHouse.DAL.Models
{
	public class Amenity
	{
		public Guid Id { get; set; }

		[Required]
		public string Name { get; set; }

		public virtual ICollection<Room> Rooms { get; set;} = new HashSet<Room>();
    }
}
