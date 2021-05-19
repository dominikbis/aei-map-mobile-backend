using AEIMapMobile.DAL.Data;
using AEIMapMobile.DAL.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Repositories.Base
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected AEIMapDbContext AEIMapDbContext { get; set; }

        public RepositoryBase(AEIMapDbContext aeiMapDbContext)
        {
            AEIMapDbContext = aeiMapDbContext;
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await AEIMapDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await AEIMapDbContext.Set<T>().FindAsync(id);
        }
    }
}
