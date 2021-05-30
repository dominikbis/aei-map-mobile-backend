using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Models
{
    public class PathDto
    {
        public IEnumerable<FloorPathDto> FloorPaths { get; set; }
    }
}
