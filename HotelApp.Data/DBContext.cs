using HotelManagementApp.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Data
{
    public class DBContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=RUKIYE-THINKPAD;Database=HotelManagementDB;Trusted_Connection=True;");
        }

        public DbSet<BuildingEntity>? Buildings { get; set; }
        public DbSet<ProductEntity>? Products { get; set; }
        public DbSet<RoomEntity>? Rooms { get; set; }
        public DbSet<WarehouseEntity>? Warehouses { get; set; }
    }
}
