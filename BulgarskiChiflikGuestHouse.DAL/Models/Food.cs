using System.ComponentModel.DataAnnotations;

namespace GuestHouse.DAL.Models
{
	public class Food
	{
		public Guid Id { get; set; }

		[Required]
		public string Name { get; set; }

        public decimal Price { get; set; }

		public string? Description { get; set; }
    }
}
