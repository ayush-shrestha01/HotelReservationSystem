using Microsoft.EntityFrameworkCore;

namespace HotelReservationSystem.Repository.Data
{
    public class HrsDbContext : DbContext
    {
        public HrsDbContext(DbContextOptions<HrsDbContext> options)
            : base(options)
        {

        }
    }
}
