using Microsoft.EntityFrameworkCore;
using TravellerWebApp.Models;

namespace TravellerWebApp.Data   // ✅ Must match your folder path
{
    public class TravellerDbContext : DbContext
    {
        public TravellerDbContext(DbContextOptions<TravellerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
