using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Models
{
    public class FilterDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<FilterValueDto> PossibleValues { get; set; }
    }
}
