using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Models
{
    public class FloorDto : AreaDto
    {
        public IEnumerable<RoomDto> Rooms { get; set; }
    }
}
