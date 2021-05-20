using AEIMapMobile.DAL.Interfaces;
using AEIMapMobile.Services.Interfaces;
using AEIMapMobile.Services.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Services
{
    public class FilteredRoomService : IFilteredRoomService
    {
        private readonly IRoomRepository roomRepository;
        private readonly IMapper mapper;

        public FilteredRoomService(IRoomRepository roomRepository, IMapper mapper)
        {
            this.roomRepository = roomRepository;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<AreaDto>> GetFilteredRoomsAsync(FilteredRoomsRequestDto request)
        {
            var entities = await roomRepository.FindRoomsByFloorId(request.FloorId);
            entities = entities.Where(e => request.FilterIds.All(id => e.FilterValues.Any(fv => fv.Id == id)));
            return mapper.Map<IEnumerable<AreaDto>>(entities);
        }
    }
}
