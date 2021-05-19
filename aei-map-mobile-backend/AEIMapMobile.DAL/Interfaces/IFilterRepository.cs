using AEIMapMobile.DAL.Entities;
using AEIMapMobile.DAL.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Interfaces
{
    public interface IFilterRepository : IRepositoryBase<Filter>
    {
        public Task<IEnumerable<Filter>> FindAllWithDetailsAsync();
    }
}
