using System.ComponentModel.DataAnnotations;

namespace GuestHouse.DAL.Models
{
	public class Reservation
	{
		public Guid Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Required]
        public ICollection<Room> Rooms { get; set; }

        public ICollection<Food>? Foods { get; set; }

        public Guid UserId { get; set; }
    }
}
