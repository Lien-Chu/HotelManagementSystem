using HotelManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementSystem.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<RoomModel> Rooms { get; set; }
		public DbSet<BookingModel> Bookings { get; set; }
		public DbSet<CustomerModel> Customers { get; set; }
		public DbSet<HotelManagementSystem.Models.RoomStatusModel> RoomStatusModel { get; set; } = default!;
	}
}