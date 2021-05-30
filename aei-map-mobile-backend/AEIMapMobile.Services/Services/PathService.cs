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
    public class PathService : IPathService
    {
        private readonly IMapper mapper;

        public PathService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public async Task<PathDto> GetPathAsync(PathRequestDto model)
        {
            return new PathDto
            {
                FloorPaths = new List<FloorPathDto>
                {
                    new FloorPathDto
                    {
                        FloorId=1,
                        Points = new List<PointDto>
                        {
                            new PointDto()
                            {
                                X=100,
                                Y=200,
                            },
                            new PointDto()
                            {
                                X=200,
                                Y=300,
                            },
                            new PointDto()
                            {
                                X=300,
                                Y=250,
                            },
                        }
                    },
                    new FloorPathDto
                    {
                        FloorId=2,
                        Points = new List<PointDto>
                        {
                            new PointDto()
                            {
                                X=140,
                                Y=260,
                            },
                            new PointDto()
                            {
                                X=300,
                                Y=200,
                            },
                            new PointDto()
                            {
                                X=500,
                                Y=350,
                            },
                        }
                    }
                }
            };
        }
    }
}
