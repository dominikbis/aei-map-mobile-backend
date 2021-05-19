using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Models
{
    public class RoomDto : AreaDto
    {
        public string Name { get; set; }
        public IEnumerable<int> FilterValueIds { get; set; }
        public IEnumerable<PointDto> Points { get; set; }
    }
}
