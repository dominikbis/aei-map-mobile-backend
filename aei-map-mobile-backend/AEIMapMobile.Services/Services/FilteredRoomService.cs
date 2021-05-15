using AEIMapMobile.Services.Interfaces;
using AEIMapMobile.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Services
{
    public class FilteredRoomService : IFilteredRoomService
    {
        public async Task<IEnumerable<AreaDto>> GetFilteredRoomsAsync(IEnumerable<int> filterIds)
        {
            var filteredRooms = new List<AreaDto>();

            if (filterIds.Any(f => f == 0))
            {
                if (filterIds.Any(f => f == 2))
                {
                    filteredRooms.Add(new AreaDto
                    {
                        Id = 1,
                        Number = 123,
                    });
                }
                else if (filterIds.All(f => f < 2))
                {
                    filteredRooms.Add(new AreaDto
                    {
                        Id = 1,
                        Number = 123,
                    });
                }
            }
            else if (filterIds.Any(f => f == 1))
            {
                if (filterIds.Any(f => f == 3))
                {
                    filteredRooms.Add(new AreaDto
                    {
                        Id = 2,
                        Number = 124,
                    });
                }
                else if (filterIds.All(f => f < 2))
                {
                    filteredRooms.Add(new AreaDto
                    {
                        Id = 2,
                        Number = 124,
                    });
                }
            }
            else
            {
                if (filterIds.Any(f => f == 2))
                {
                    filteredRooms.Add(new AreaDto
                    {
                        Id = 1,
                        Number = 123,
                    });
                }
                else if (filterIds.Any(f => f == 2))
                {
                    filteredRooms.Add(new AreaDto
                    {
                        Id = 2,
                        Number = 124,
                    });
                }
                else
                {
                    filteredRooms.Add(new AreaDto
                    {
                        Id = 1,
                        Number = 123,
                    });
                    filteredRooms.Add(new AreaDto
                    {
                        Id = 2,
                        Number = 124,
                    });
                }
            }

            return filteredRooms;
        }
    }
}
