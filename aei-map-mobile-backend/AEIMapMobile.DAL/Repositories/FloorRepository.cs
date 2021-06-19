using AEIMapMobile.DAL.Data;
using AEIMapMobile.DAL.Entities;
using AEIMapMobile.DAL.Interfaces;
using AEIMapMobile.DAL.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Repositories
{
    public class FloorRepository : RepositoryBase<Floor>, IFloorRepository
    {
        public FloorRepository(AEIMapDbContext aeiMapDbContext) : base(aeiMapDbContext)
        {

        }

        public async Task<Floor> FindByIdWithDetailsAsync(int id)
        {
            return await AEIMapDbContext.Set<Floor>()
                .Include(e => e.SectorConnections)
                .Include(e => e.Rooms)
                .Include(e => e.Rooms).ThenInclude(x => x.Points)
                .Include(e => e.Rooms).ThenInclude(x => x.FilterValues)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Floor> FindByNumberWithDetailsAsync(int number)
        {
            return await AEIMapDbContext.Set<Floor>()
                .Include(e => e.SectorConnections)
                .Include(e => e.Rooms)
                .Include(e => e.Rooms).ThenInclude(x => x.Points)
                .Include(e => e.Rooms).ThenInclude(x => x.FilterValues)
                .FirstOrDefaultAsync(e => e.Number == number);
        }
    }
}
