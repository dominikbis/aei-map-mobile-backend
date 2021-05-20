using AEIMapMobile.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Data
{
    public class AEIMapDbContext : DbContext
    {
        public AEIMapDbContext(DbContextOptions<AEIMapDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RoomPoint>().HasIndex(rp => new { rp.Order, rp.RoomId }).IsUnique(true);
        }

        public DbSet<Floor> Floors { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<FilterValue> FilterValues { get; set; }
        public DbSet<RoomPoint> RoomPoints { get; set; }
    }
}
