using AEIMapMobile.Services.Interfaces;
using AEIMapMobile.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Services
{
    public class FloorService : IFloorService
    {
        public async Task<FloorDto> GetFloorByIdAsync(int id)
        {
            //var entities = await carModelRepository.FindAllWithDetailsAsync();
            //return mapper.Map<IEnumerable<CarModelListItemDto>>(entities);

            var model = new FloorDto
            {
                Id = 1,
                Number = 1,
                Path = null,
                Rooms = new List<RoomDto>
                {
                    new RoomDto
                    {
                        Id=1,
                        Name="ROOM1",
                        Number=123,
                        Types= new List<int>
                        {
                            1
                        },
                        Points=new List<PointDto>
                        {
                            new PointDto
                            {
                                X=100,
                                Y=100,
                            },
                            new PointDto
                            {
                                X=300,
                                Y=100,
                            },
                             new PointDto
                            {
                                X=300,
                                Y=300,
                            },
                            new PointDto
                            {
                                X=100,
                                Y=300,
                            },
                        }

                    },
                    new RoomDto
                    {
                        Id=2,
                        Name="ROOM2",
                        Number=124,
                        Types= new List<int>
                        {
                            2
                        },
                        Points=new List<PointDto>
                        {
                            new PointDto
                            {
                                X=150,
                                Y=300,
                            },
                            new PointDto
                            {
                                X=300,
                                Y=300,
                            },
                             new PointDto
                            {
                                X=300,
                                Y=600,
                            },
                            new PointDto
                            {
                                X=150,
                                Y=600,
                            },
                        }

                    }
                }
            };

            return model;
        }
    }
}
