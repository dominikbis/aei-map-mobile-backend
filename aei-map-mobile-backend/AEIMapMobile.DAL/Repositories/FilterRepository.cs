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
    public class FilterRepository : RepositoryBase<Filter>, IFilterRepository
    {
        public FilterRepository(AEIMapDbContext aeiMapDbContext) : base(aeiMapDbContext)
        {

        }

        public async Task<IEnumerable<Filter>> FindAllWithDetailsAsync()
        {
            return await AEIMapDbContext.Set<Filter>()
                .Include(e => e.FilterValues)
                .ToListAsync();
        }
    }
}
