using AEIMapMobile.Services.Interfaces;
using AEIMapMobile.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Services
{
    public class FilterService : IFilterService
    {
        public async Task<IEnumerable<FilterDto>> GetAllFiltersAsync()
        {
            return new List<FilterDto>
            {
                new FilterDto
                {
                    Id = 0,
                    Name = "Type",
                    PossibleValues = new List<FilterValueDto>
                    {
                        new FilterValueDto { Id = 0, Name = "Computer" },
                        new FilterValueDto { Id = 1, Name = "Lecture hall" },
                    },
                },
                new FilterDto
                {
                    Id = 1,
                    Name = "Size",
                    PossibleValues = new List<FilterValueDto>
                    {
                        new FilterValueDto { Id = 2, Name = "Small" },
                        new FilterValueDto { Id = 3, Name = "Medium" },
                        new FilterValueDto { Id = 4, Name = "Big" },
                    },
                },
            };
        }
    }
}
