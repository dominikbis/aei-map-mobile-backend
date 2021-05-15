using AEIMapMobile.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Interfaces
{
    public interface IFilteredRoomService
    {
        public Task<IEnumerable<AreaDto>> GetFilteredRoomsAsync(IEnumerable<int> filterIds);
    }
}
