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

            builder.Entity<Room>(room =>
            {
                room.HasIndex(r => r.Id).IsUnique(true);

                room.HasIndex(r => r.Number).IsUnique(true);

                room.HasIndex(r => r.ExitPointId).IsUnique(true);
            });

            builder.Entity<NextPathPoint>(nextPathPoint =>
            {
                nextPathPoint.HasKey(npp => new { npp.SourcePointId, npp.NextPointId });

                nextPathPoint.HasIndex(npp => npp.SourcePointId);

                nextPathPoint.HasOne(npp => npp.SourcePoint)
                    .WithMany(pp => pp.SourcePathPoints)
                    .HasForeignKey(npp => npp.SourcePointId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.NoAction);

                nextPathPoint.HasOne(npp => npp.NextPoint)
                    .WithMany(pp => pp.NextPathPoints)
                    .HasForeignKey(npp => npp.NextPointId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.NoAction);
            });

            builder.Entity<FloorSectorConnection>(floorSectorConnection =>
            {
                floorSectorConnection.HasKey(fsc => new { fsc.FloorId, fsc.Sector1Id, fsc.Sector2Id });

                floorSectorConnection.HasIndex(fsc => fsc.FloorId);

                floorSectorConnection.HasOne(fsc => fsc.Floor)
                    .WithMany(f => f.SectorConnections)
                    .HasForeignKey(fsc => fsc.FloorId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.NoAction);

                floorSectorConnection.HasOne(fsc => fsc.Sector1)
                    .WithMany(s => s.Sector1Connections)
                    .HasForeignKey(fsc => fsc.Sector1Id)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.NoAction);

                floorSectorConnection.HasOne(fsc => fsc.Sector2)
                    .WithMany(s => s.Sector2Connections)
                    .HasForeignKey(fsc => fsc.Sector2Id)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.NoAction);
            });
        }

        public DbSet<Floor> Floors { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<FilterValue> FilterValues { get; set; }
        public DbSet<RoomPoint> RoomPoints { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<PathPoint> PathPoints { get; set; }
        public DbSet<FloorSectorConnection> FloorSectorConnections { get; set; }
        public DbSet<NextPathPoint> NextPathPoints { get; set; }
    }
}
