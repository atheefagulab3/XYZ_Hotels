using Library.Models;
using Microsoft.EntityFrameworkCore;
using XYZ_Hotels.Models;

namespace XYZ_Hotels.DB
{
    public class HotelContext : DbContext
    {
        public DbSet<hotels> Hotels { get; set; }

        public DbSet<Rooms> Rooms { get; set; }

        public DbSet<Users> Users { get; set; }


        public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }


    }
}
