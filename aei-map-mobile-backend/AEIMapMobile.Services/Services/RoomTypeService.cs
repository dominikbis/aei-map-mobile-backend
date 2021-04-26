using AEIMapMobile.Services.Interfaces;
using AEIMapMobile.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        public async Task<IEnumerable<RoomTypeDto>> GetAllRoomTypesAsync()
        {
            //var entities = await carModelRepository.FindAllWithDetailsAsync();
            //return mapper.Map<IEnumerable<CarModelListItemDto>>(entities);

            var models = new List<RoomTypeDto>
            { 
                new RoomTypeDto
                {
                    Id=1,
                    Name="Computer"
                },
                new RoomTypeDto
                {
                    Id=2,
                    Name="Lecture hall"
                },
            };

            return models;
        }
    }
}
