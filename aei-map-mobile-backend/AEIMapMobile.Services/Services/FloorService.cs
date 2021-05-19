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
    public class FloorService : IFloorService
    {
        private readonly IFloorRepository floorRepository;
        private readonly IMapper mapper;

        public FloorService(IFloorRepository floorRepository, IMapper mapper)
        {
            this.floorRepository = floorRepository;
            this.mapper = mapper;
        }

        public async Task<FloorDto> GetByIdWithDetailsAsync(int id)
        {
            var entities = await floorRepository.FindByIdWithDetailsAsync(id);
            return mapper.Map<FloorDto>(entities);
        }

        public async Task<IEnumerable<AreaDto>> GetAllAsync()
        {
            var entities = await floorRepository.FindAllAsync();
            return mapper.Map<IEnumerable<AreaDto>>(entities);
        }
    }
}
