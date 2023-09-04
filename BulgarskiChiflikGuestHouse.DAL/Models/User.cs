using System.ComponentModel.DataAnnotations;

namespace GuestHouse.DAL.Models
{
	public class User
	{
		public Guid Id { get; set; }

        [Required]
        public string Username { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public ICollection<Reservation>? Reservations { get; set; }
    }
}
