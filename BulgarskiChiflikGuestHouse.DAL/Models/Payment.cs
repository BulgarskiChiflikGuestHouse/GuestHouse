namespace GuestHouse.DAL.Models
{
	public class Payment
	{
		public Guid Id { get; set; }

		public Guid UserId { get; set; }

        public Guid ReservationId { get; set; }

        public DateTime PaymentDate { get; set; }

        public decimal Amount { get; set; }
    }
}
