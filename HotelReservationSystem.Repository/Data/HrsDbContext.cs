using HotelReservationSystem.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelReservationSystem.Repository.Data
{
    public class HrsDbContext : DbContext
    {
        public HrsDbContext(DbContextOptions<HrsDbContext> options)
            : base(options)
        {
        }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<User> User { get; set; }

    }
}
