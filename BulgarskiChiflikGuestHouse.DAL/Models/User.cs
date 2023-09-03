using System.ComponentModel.DataAnnotations;

namespace GuestHouse.DAL.Models
{
	public class User
	{
		public Guid Id { get; set; }

        public string Username { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
