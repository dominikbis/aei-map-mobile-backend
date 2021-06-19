﻿using AEIMapMobile.DAL.Data;
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
    public class PathPointRepository : RepositoryBase<PathPoint>, IPathPointRepository
    {
        public PathPointRepository(AEIMapDbContext aeiMapDbContext) : base(aeiMapDbContext)
        {

        }

        public async Task<IEnumerable<PathPoint>> FindByFloorIdAsync(int floorId)
        {
            return await AEIMapDbContext.Set<PathPoint>()
                 .Where(e => e.Floor.Id == floorId)
                 .Include(e => e.NextPathPoints)
                 .Include(e => e.SourcePathPoints)
                 .ToListAsync();
        }
    }
}
