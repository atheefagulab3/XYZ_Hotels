using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace XYZ_Hotels.Models
{
    public class HotelContext : DbContext
    {
        public DbSet<hotels> Hotels { get; set; }

        public DbSet<Rooms> Rooms { get; set; }

        public DbSet<Users> Users { get; set; }

       
        public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }
      

    }
}
