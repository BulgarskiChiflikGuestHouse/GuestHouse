using System.ComponentModel.DataAnnotations;

namespace GuestHouse.DAL.Models
{
	public class Event
	{
		public Guid Id { get; set; }

		[Required]
		public string Name { get; set; }

		public string? Description { get; set; }

		public DateTime StartDate { get; set; }

        public int DurationInMinutes { get; set; }
    }
}
