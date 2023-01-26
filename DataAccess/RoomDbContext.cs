using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class RoomDbContext : DbContext
    {
        public RoomDbContext(DbContextOptions<RoomDbContext> options) : base(options)
        {

        }
        public DbSet<RoomEntity> Rooms {get; set;}
    }
}
