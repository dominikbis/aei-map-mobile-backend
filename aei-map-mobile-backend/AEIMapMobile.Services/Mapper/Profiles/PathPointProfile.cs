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
    class PathPointProfile : Profile
    {
        public PathPointProfile()
        {
            CreateMap<IEnumerable<IEnumerable<PathPoint>>, PathDto>()
                .ForMember(dest => dest.FloorPaths, opts => opts.MapFrom(src => src));

            CreateMap<IEnumerable<PathPoint>, FloorPathDto>()
                .ForMember(dest => dest.FloorId, opts => opts.MapFrom(src => src.First().FloorId))
                .ForMember(dest => dest.Points, opts => opts.MapFrom(src => src));

            CreateMap<PathPoint, PointDto>();
        }
    }
}
