using AEIMapMobile.DAL.Data;
using AEIMapMobile.DAL.Interfaces;
using AEIMapMobile.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            services
                // Repositories
                .AddScoped<IFloorRepository, FloorRepository>()
                .AddScoped<IFilterRepository, FilterRepository>()

                // Databases
                .AddDbContext<AEIMapDbContext>(options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("AEIMapConnectionString"));
                });
            return services;
        }
    }
}
