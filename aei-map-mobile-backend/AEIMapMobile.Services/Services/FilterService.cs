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
    public class FilterService : IFilterService
    {
        private readonly IFilterRepository filterRepository;
        private readonly IMapper mapper;

        public FilterService(IFilterRepository filterRepository, IMapper mapper)
        {
            this.filterRepository = filterRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<FilterDto>> GetAllWithDetailsAsync()
        {
            var entities = await filterRepository.FindAllWithDetailsAsync();
            return mapper.Map<IEnumerable<FilterDto>>(entities);
        }
    }
}
