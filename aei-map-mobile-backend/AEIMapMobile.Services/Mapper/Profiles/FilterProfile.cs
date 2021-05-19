using AEIMapMobile.DAL.Entities;
using AEIMapMobile.Services.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Mapper.Profiles
{
    public class FilterProfile : Profile
    {
        public FilterProfile()
        {
            CreateMap<Filter, FilterDto>()
                .ForMember(dest => dest.PossibleValues, opts => opts.MapFrom(src => src.FilterValues));
        }
    }
}
