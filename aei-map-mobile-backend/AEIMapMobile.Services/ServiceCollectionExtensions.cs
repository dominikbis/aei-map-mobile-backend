using AEIMapMobile.DAL;
using AEIMapMobile.Services.Interfaces;
using AEIMapMobile.Services.Mapper;
using AEIMapMobile.Services.Mapper.Configuration;
using AEIMapMobile.Services.Mapper.Profiles;
using AEIMapMobile.Services.Services;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services
                //services
                .AddScoped<IFloorService, FloorService>()
                .AddScoped<IFilterService, FilterService>()
                .AddScoped<IFilteredRoomService, FilteredRoomService>()

                // AutoMapper
                .AddSingleton<AutoMapper.IConfigurationProvider, AutoMapperConfiguration>(p => new AutoMapperConfiguration(p.GetServices<Profile>()))
                .AddSingleton<IMapper, AutoMapper.Mapper>()

                // AutoMapper profiles
                .AddSingleton<Profile, FloorProfile>()
                .AddSingleton<Profile, RoomProfile>()
                .AddSingleton<Profile, RoomPointProfile>()
                .AddSingleton<Profile, FilterProfile>()
                .AddSingleton<Profile, FilterValueProfile>()

                //data access
                .AddDataAccess(configuration);
            return services;
        }
    }
}
