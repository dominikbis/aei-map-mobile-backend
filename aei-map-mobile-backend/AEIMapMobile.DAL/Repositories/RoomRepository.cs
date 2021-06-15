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
    public class RoomRepository : RepositoryBase<Room>, IRoomRepository
    {
        public RoomRepository(AEIMapDbContext aeiMapDbContext) : base(aeiMapDbContext)
        {

        }

        public async Task<IEnumerable<Room>> FindByFloorIdAsync(int floorId)
        {
            return await AEIMapDbContext.Set<Room>()
                 .Include(e => e.FilterValues)
                 .Where(e => e.Floor.Id == floorId)
                 .ToListAsync();
        }
    }
}
