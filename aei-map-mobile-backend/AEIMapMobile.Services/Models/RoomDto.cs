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
        public List<int> Types { get; set; }
        public List<PointDto> Points { get; set; }
    }
}
