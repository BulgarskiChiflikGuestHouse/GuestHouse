using Microsoft.EntityFrameworkCore;

namespace GuestHouse.DAL
{
	public class GuestHouseDbContext : DbContext
	{
        public GuestHouseDbContext(DbContextOptions<GuestHouseDbContext> options)
			: base(options)
        {
			
        }

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
