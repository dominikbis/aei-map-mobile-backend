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
    public class RoomProfile : Profile
    {
        public RoomProfile()
        {
            CreateMap<Room, RoomDto>()
                .ForMember(dest => dest.FilterValueIds, opts => opts.MapFrom(src => src.FilterValues.Select(e => e.Id)));
        }
    }
}
