using GuestHouse.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace GuestHouse.DAL
{
	public class GuestHouseDbContext : DbContext
	{
        public GuestHouseDbContext(DbContextOptions<GuestHouseDbContext> options)
			: base(options)
        {
			
        }

        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}
	}
}