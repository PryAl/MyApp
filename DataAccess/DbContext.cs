using Domain.Entities;
using Domain.Entities.DeviceTypes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Premise> Premises {get; set;}
        public DbSet<Room> Rooms {get; set;}
        public DbSet<Device> Devices {get; set;}
        public DbSet<DeviceType> DeviceTypes {get; set;}
        public DbSet<Luminaire> Luminaires {get; set;}
        public DbSet<Socket> Sockets {get; set;}
        public DbSet<Thermostat> Thermostats {get; set;}
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Premise>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Room>()
                .HasKey(r => r.Id);
            modelBuilder.Entity<Device>()
                .HasKey(d => d.Id);
            modelBuilder.Entity<DeviceType>()
                .HasKey(dt => dt.Id);

            modelBuilder.Entity<Room>()
                .HasOne(r => r.Premise)
                .WithMany(p => p.Rooms)
                .HasForeignKey(r => r.Premise_Id);

            modelBuilder.Entity<Device>()
                .HasOne(r => r.Room)
                .WithMany(d => d.Devices)
                .HasForeignKey(d => d.Room_Id);

            modelBuilder.Entity<Device>()
                .HasOne(d => d.DeviceType)
                .WithMany()
                .HasForeignKey(d => d.DeviceType_Id);

            modelBuilder.Entity<Luminaire>()
                .ToTable("Luminaries");
            modelBuilder.Entity<Socket>()
                .ToTable("Sockets");
            modelBuilder.Entity<Thermostat>()
                .ToTable("Thermostats");
        }
    }
}
