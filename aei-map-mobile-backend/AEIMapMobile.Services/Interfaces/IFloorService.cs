using AEIMapMobile.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Interfaces
{
    public interface IFloorService
    {
        public Task<FloorDto> GetByIdWithDetailsAsync(int id);
        public Task<IEnumerable<AreaDto>> GetAllAsync();
    }
}
